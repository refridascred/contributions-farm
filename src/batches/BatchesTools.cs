using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            New,
            Active,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }
    }
}
