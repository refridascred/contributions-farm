using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 432;
        public const string WindowFactor = "standard";
        public const long LimitTimeout = 2557;

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool CheckReportCommitsBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
