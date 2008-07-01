using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}
