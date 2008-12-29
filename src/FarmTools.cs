using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Stale,
            Failed,
            Pending,
            New,
        }
    }
}
