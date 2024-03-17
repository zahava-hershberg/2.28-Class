using _2._28_Class.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2._28_Class.Web.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

    }
}