using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
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
