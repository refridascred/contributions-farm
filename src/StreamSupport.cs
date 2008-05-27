using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 5113;
        public const long DefaultBudget = 1971;
        public const long LimitWindow = 3412;

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
