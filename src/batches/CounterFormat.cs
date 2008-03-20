using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Queued,
            New,
            Paused,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
