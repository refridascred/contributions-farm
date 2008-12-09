using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 6032;
        public const string BaseSize = "legacy-v2";
        public const double HardScore = 45.26;
        public const double MinLevel = 17.03;
        public const long HardBudget = 8146;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
