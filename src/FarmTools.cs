using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 38.77;
        public const long SoftCluster = 7232;
        public const string HardCluster = "alpha-1";
        public const string BaseDepth = "alpha-1";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
