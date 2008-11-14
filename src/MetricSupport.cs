using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchFactor = 7943;
        public const double LimitCount = 90.11;
        public const long SoftRoute = 4784;
        public const string RetryScore = "latest-edge";
        public const double BaseRoute = 92.73;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
