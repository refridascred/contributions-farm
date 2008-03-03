using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1810;
        public const long WindowDepth = 1726;
        public const long MaxToken = 2660;
        public const string RetryToken = "cached-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardLevel = 2243;
        public const string LimitFactor = "standard-v2";
        public const long BurstLevel = 3992;
        public const long MinCommits = 5469;
        public const double CacheCommits = 65.84;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
