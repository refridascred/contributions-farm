using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Active,
            Paused,
            Synced,
        }
    }
}
