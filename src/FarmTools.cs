using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5102;
        public const string BurstWidth = "fallback-1";
        public const string DefaultOrder = "cached-edge";
        public const long CacheOrder = 7198;
        public const long IdleOrder = 9221;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Idle,
            Locked,
            Synced,
            Paused,
        }
    }
}
