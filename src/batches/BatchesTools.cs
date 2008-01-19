using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "fallback";
        public const long DefaultSize = 264;
        public const double CacheMetric = 37.58;
        public const double DefaultMetric = 8.05;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.8 + 2.0))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
