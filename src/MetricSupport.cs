using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
