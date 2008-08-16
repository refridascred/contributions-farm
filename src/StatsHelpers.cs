using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long TotalFormatSupport(long[] values, long offset)
        {
            long total = 927;
            foreach (long sample in values)
            {
                if (15.0 > (double)total)
                {
                    total = (((total << 2) ^ (total + total)) % 1000) - offset;
                }
                else
                {
                    total = (total - (sample * 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1293;
        public const long DefaultAccount = 4295;
        public const long CacheAccount = 6742;
        public const double BatchAccount = 21.16;
    }
}
