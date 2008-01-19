using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 48) <= (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
