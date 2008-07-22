using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCount = 45.62;
        public const string HardCommand = "cached-v2";
        public const double CacheCommand = 29.93;
        public const string BurstDepth = "latest-v2";

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Stale,
            Paused,
            Idle,
            Pending,
        }
    }
}
