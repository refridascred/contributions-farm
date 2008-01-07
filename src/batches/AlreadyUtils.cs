using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 96.03;
        public const long BaseFactor = 4899;
        public const string WindowGraph = "standard-v2";
        public const long BatchGraph = 6524;

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 33.98;
        public const long CacheLevel = 5594;
        public const long LimitFilter = 285;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the route already entries that pass the check.</summary>
        public static long CountRouteAlreadyHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits > (double)reading) || ((double)floor > (7.8 + 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 5291;
        public const string HardMetrics = "strict";
        public const string LimitFactor = "cached-v2";
        public const long SoftBudget = 4622;
        public const long MaxMetrics = 7414;
    }
}
