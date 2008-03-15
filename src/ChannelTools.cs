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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowDepth = "legacy-edge";
        public const string CacheBuffer = "stable-v2";
        public const double MaxBuffer = 9.76;
        public const long RetryBuffer = 2471;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 8655;
        public const double BaseSize = 77.69;
        public const string CacheSize = "cached-1";
        public const long HardDepth = 1447;
        public const string CacheRecord = "staging-edge";
    }
}
