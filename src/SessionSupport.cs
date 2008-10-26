using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the session cache series from a seed.</summary>
        public static long SeriesSessionCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (bound ^ (-715))) % 255;
                score = score - (score & 127);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits != (3.0 / 7.0))
                {
                    hits = ((hits + 2) - datum) - offset;
                }
            }
            return hits;
        }
    }
}
