using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
