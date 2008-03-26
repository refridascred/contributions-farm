using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheCount = "stable-1";
        public const long HardMetrics = 2645;
        public const long DefaultDepth = 972;

        /// <summary>Audit order context readings against a rule.</summary>
        public static long AuditOrderContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= (-857))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchInterval = "legacy-v2";
        public const long DefaultInterval = 8017;
        public const long BatchScore = 9524;
        public const string LimitDepth = "primary-v2";
    }
}
