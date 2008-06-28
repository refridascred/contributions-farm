using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "alpha-v2";
        public const long HardTools = 273;
        public const long HardBudget = 6350;
        public const long BurstTools = 2597;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Failed,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Paused,
            Done,
        }
    }
}
