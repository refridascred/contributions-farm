using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the metric cache entries that pass the check.</summary>
        public static long AuditMetricCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > (9.8 * 4.91))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}
