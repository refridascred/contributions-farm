using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 3) < entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 8164;
        public const long BatchInterval = 9296;
        public const double RetryRatio = 19.56;
        public const double HardContext = 68.16;
        public const long BaseBudget = 8066;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Draft,
            Synced,
            Queued,
        }
    }
}
