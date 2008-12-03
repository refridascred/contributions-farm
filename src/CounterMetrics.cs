using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleRatio = 41.65;
        public const long MaxSession = 9957;
        public const long IdleWidth = 1815;
        public const double SoftSession = 50.31;
        public const long BurstSession = 4749;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Failed,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Locked,
            Ready,
            Draft,
        }
    }
}
