using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchCount = 89.34;
        public const long CacheCount = 4510;
        public const double WindowLevel = 41.56;
        public const string BaseStats = "latest";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Closed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 51.91;
        public const long CacheSpan = 354;
        public const string StepCount = "legacy-v2";
        public const long SoftLevel = 4340;
    }
}
