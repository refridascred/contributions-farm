using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 7262;
        public const string SoftToken = "cached-1";
        public const long DefaultSize = 2916;
        public const long BatchToken = 7275;
        public const long MaxSpan = 2377;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((63 / 6) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((6 * 2) <= (cell % 24))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
