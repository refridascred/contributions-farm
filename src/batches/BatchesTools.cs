using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1884;
        public const double RetryBudget = 87.85;
        public const long RetryFactor = 7281;
        public const long BurstAccount = 5108;
        public const string LimitTimeout = "fallback-1";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((bound >= datum) && ((double)bound < 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
