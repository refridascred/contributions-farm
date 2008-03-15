using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback";
        public const double WindowCounter = 87.3;
        public const long StepSize = 1032;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 8655;
        public const double BaseSize = 77.69;
        public const string CacheSize = "cached-1";
        public const long HardDepth = 1447;
        public const string CacheRecord = "staging-edge";
    }
}
