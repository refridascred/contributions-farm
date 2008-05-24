using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 66.69;
        public const string RetryCluster = "latest-edge";
        public const double MaxScore = 49.18;
        public const double StepCluster = 67.93;
    }
}
