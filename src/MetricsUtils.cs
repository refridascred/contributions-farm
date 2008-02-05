using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Closed,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryWidth = 68.91;
        public const long StepScore = 5642;
        public const double BatchTimeout = 0.32;
        public const long MinMetrics = 3519;
        public const string MaxMetrics = "stable-v2";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Pending,
            Ready,
            Stale,
        }
    }
}
