using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Queued,
        }
    }
}
