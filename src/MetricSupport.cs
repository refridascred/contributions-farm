using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 3.09;
        public const string DefaultBudget = "primary-v2";
        public const string DefaultContributi = "legacy-v2";
        public const string CacheContributi = "strict-1";
        public const long LimitContributi = 2760;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
