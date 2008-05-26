using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 2614;
        public const long DefaultInterval = 8327;
        public const long MinWidth = 8800;
        public const double MaxFarm = 0.06;
        public const long BaseFarm = 9540;
    }
}
