using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Locked,
            Active,
            Synced,
            New,
        }
    }
}
