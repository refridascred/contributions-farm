using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2061;
        public const long BatchWindow = 6847;
        public const long LimitWidth = 5340;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Ready,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "legacy-v2";
        public const long BatchFactor = 7898;
        public const long CacheLayout = 1085;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "standard-1";
        public const long DefaultRoute = 1642;
        public const long BaseBudget = 5045;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit > (value & 127))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
