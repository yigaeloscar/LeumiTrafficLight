using Microsoft.AspNetCore.Mvc;

namespace TrafficLightSimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LightsContainsLogicController : ControllerBase
    {
        // GET api/<LightsContainsLogicController>/5
        [Route("LightsContains")]
        public Timing Get(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                Timing timing = new Timing();
                timing.color = "red";
                timing.time = 3000;
                return (timing);
            }
            switch (color)
            {
                case "red":
                    Timing timing = new Timing();
                    timing.color = "red";
                    timing.time = 3000;
                    return (timing);
                case "redyellow":
                    Timing timing1 = new Timing();
                    timing1.color = "redyellow";
                    timing1.time = 1500;
                    return (timing1);
                case "green":
                    Timing timing2 = new Timing();
                    timing2.color = "green";
                    timing2.time = 3000;
                    return (timing2);
                case "yellow":
                    Timing timing3 = new Timing();
                    timing3.color = "yellow";
                    timing3.time = 1500;
                    return (timing3);
            }
            return null;
        }
    }

    public class Timing
    {
        public string color { get; set; }
        public double time { get; set; }
    }
}
