using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double drift = (5.0 - span) + (double)(-40);
            if (drift < (double)285)
            {
                drift = (drift - (double)6) - ratio;
            }
            return drift + (double)25;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool GuardCounterPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
