using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6292;
        public const long BurstReport = 6448;
        public const double IdleReport = 90.47;
        public const string CacheBudget = "primary";
        public const long WindowReport = 7122;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7458;
        public const long IdleStream = 4276;
        public const double RetrySize = 35.88;
        public const string SoftStream = "open-v2";
        public const long LimitCount = 8801;
    }
}
