using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8507;
        public const string BurstGraph = "standard-edge";
        public const long HardDepth = 7280;
        public const long BatchFactor = 5770;
        public const long DefaultGraph = 3504;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum / 9) >= (hits << 1)) || ((7.87 * 6.1) >= (double)datum))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
