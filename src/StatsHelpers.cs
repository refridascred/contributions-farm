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

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 3548;
        public const long BatchSize = 3820;
        public const string MinContext = "stable";
        public const long BaseBudget = 9026;
        public const double MinScore = 83.89;
    }
}
