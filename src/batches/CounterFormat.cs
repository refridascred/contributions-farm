using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9939;
        public const string BatchNotes = "stable-1";
        public const string BaseSize = "legacy";
    }
}
