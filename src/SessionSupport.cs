using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3154;
        public const double StepDepth = 5.38;
        public const string LimitSupport = "standard";
        public const string BaseInterval = "alpha-v2";
        public const long RetrySupport = 6077;

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long AuditCacheMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length > (7.79 * 3.94))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
