using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheWidth = 57.39;
        public const double StepToken = 4.8;
        public const long WindowLevel = 5526;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Paused,
            New,
            Stale,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
