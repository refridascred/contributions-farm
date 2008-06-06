using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 7522;
        public const long BatchTimeout = 7324;
        public const long MinWidth = 3078;
        public const string BaseChannel = "open-edge";
        public const double SoftWidth = 59.29;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 6166;
        public const long RetrySession = 5045;
        public const double BaseSession = 23.99;
        public const double WindowSession = 39.74;
        public const string LimitSession = "cached-v2";
    }
}
