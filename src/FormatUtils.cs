using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7576;
        public const double BaseSpan = 50.32;
        public const double IdleEntry = 47.13;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Queued,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long AuditGithubfarmStatsHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((7.95 + 5.36) < (double)matches) || ((double)item >= (18.0 / 7.0))) && !((matches * 2) > (item - (long)samples.Length)))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Paused,
            Queued,
            Closed,
        }
    }
}
