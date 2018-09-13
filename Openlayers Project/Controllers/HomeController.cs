using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Openlayers_Project.Models;
using System.IO;

namespace Openlayers_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Openlayers()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult OLInteractions()
        {
            return View();
        }

        public string GetStraitsJson()
        {
            string json = null;
            using (StreamReader sr = new StreamReader(@"D:\\Data Files\straits.json"))
            {
                json = sr.ReadToEnd();
                return json;
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
