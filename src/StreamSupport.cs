using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "primary-v2";
        public const long SoftAccount = 6671;
        public const long StepRatio = 4219;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 6717;
        public const double RetrySpan = 41.6;
        public const string BatchLevel = "standard-v2";
        public const double CacheSpan = 52.86;
    }
}
