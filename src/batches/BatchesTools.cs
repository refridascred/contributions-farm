using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 3654;
        public const long MinStream = 8285;
        public const string BurstLevel = "cached";
        public const long HardStream = 4468;

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultSpan = 3944;
        public const string HardBudget = "fallback-v2";
        public const double DefaultEditor = 28.59;
        public const double LimitEditor = 47.84;
    }
}
