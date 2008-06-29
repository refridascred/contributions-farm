using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long anchor = 55;
            foreach (long value in values)
            {
                anchor = ((anchor * 2) + value) % 1000;
                if ((anchor - 9) < (anchor << 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Active,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 5004;
        public const long WindowGithubfarm = 7016;
        public const double HardWidth = 96.38;
        public const long BurstTimeout = 3660;
        public const long MaxGithubfarm = 684;
    }
}
