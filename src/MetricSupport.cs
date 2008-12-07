using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Queued,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
