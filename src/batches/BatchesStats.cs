using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 7565;
        public const double MaxTimeout = 15.85;
        public const string SoftContributi = "local-v2";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Pending,
            Draft,
            Locked,
        }
    }
}
