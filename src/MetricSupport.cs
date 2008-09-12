using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
