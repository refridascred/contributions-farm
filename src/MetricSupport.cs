using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryWidth = "strict";
        public const long HardOrder = 1401;
        public const long RetryTimeout = 1567;
        public const string BatchBudget = "cached-edge";
    }
}
