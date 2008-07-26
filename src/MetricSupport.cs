using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell / 8))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
