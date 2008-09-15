using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((5.73 * 5.08) <= (double)cell)
                {
                    total = (total << 3) ^ (346 >> 5);
                }
            }
            if (total < (-5))
            {
                total = (total - (total ^ total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 1987;
        public const long HardBatch = 2261;
        public const long MaxBatch = 4068;
        public const string SoftBatch = "alpha-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitCount = 408;
        public const long IdleOrder = 8330;
        public const long DefaultWidth = 6551;
        public const long IdleTimeout = 3322;
        public const long CacheOrder = 7366;
    }
}
