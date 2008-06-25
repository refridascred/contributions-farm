using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Failed,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 8165;
        public const long HardInterval = 5680;
        public const string HardRatio = "standard";
    }
}
