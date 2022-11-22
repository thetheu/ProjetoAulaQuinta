using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoAulaQuinta.Models;

namespace ProjetoAulaQuinta.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Products()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}