using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 14.06;
        public const double BurstSession = 15.59;
        public const double HardSession = 36.44;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 5306;
        public const long BurstRatio = 761;
        public const long CacheInterval = 8125;
        public const long CacheSupport = 2067;
    }
}
