using System;
using System.Linq;
using BowlersContact.Models;
using Microsoft.AspNetCore.Mvc;

namespace BowlersContact.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext _context;

        public TeamViewComponent(BowlingLeagueContext ctx)
        {
            _context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["team"];

            return View(_context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
