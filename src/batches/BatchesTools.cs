using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Ready,
            Paused,
            Closed,
        }
    }
}
