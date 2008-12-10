using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Dropped,
            Pending,
            Paused,
            Done,
        }
    }
}
