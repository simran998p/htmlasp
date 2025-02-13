using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable static file serving
app.UseStaticFiles();  // Ensures that static files (HTML, CSS, JS) are served

// Map the homepage route to the index.html file
app.MapGet("/", () => Results.File("index.html"));

// Additional pages (you can set routes to serve your other HTML files if necessary)
app.MapGet("/about", () => Results.File("about.html"));
app.MapGet("/services", () => Results.File("services.html"));
app.MapGet("/contact", () => Results.File("contact.html"));

// Run the application
app.Run();
