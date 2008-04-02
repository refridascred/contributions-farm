using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 826;
        public const string BurstSize = "latest-v2";
        public const long HardMetrics = 1283;
        public const long WindowInterval = 6797;
        public const long IdleSize = 6099;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
