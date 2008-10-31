using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches & 31) < matches)
                {
                    matches = ((matches + 2) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSpan = 5594;
        public const long LimitLevel = 9826;
        public const string HardStream = "standard-v2";
        public const double WindowStream = 40.73;
        public const long LimitScore = 129;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Locked,
            Paused,
        }
    }
}
