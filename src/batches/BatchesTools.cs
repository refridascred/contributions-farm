using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4924;
        public const long BaseBatches = 4602;
        public const double RetryBatches = 65.81;
    }
}
