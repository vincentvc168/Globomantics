﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Globomantics.Controllers
{
    public class ConferenceController : Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}
