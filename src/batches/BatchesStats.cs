using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxRatio = 46.38;
        public const double WindowNotes = 65.74;
        public const long SoftNotes = 653;

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
