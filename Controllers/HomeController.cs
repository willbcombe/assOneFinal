using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assOneFinal.Models;
using PaulMiami.AspNetCore.Mvc.Recaptcha;
using assOneFinal.Models.LoginViewModels;

namespace assOneFinal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [ValidateRecaptcha]
        [HttpPost]
        public IActionResult About(LoginVM viewModel)
        {
            ViewData["Message"] = "Your application description page.";
            if (ModelState.IsValid)
            {
                ViewBag.CaptchaSuccess = "It worked!";
                return View();
            }
            ViewBag.CaptchaSuccess = "It worked!";
            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
