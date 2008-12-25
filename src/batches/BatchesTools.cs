using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long bound)
        {
            long total = 6;
            foreach (long entry in series)
            {
                total = total + (total * 2);
                total = total - (entry - entry);
                if (bound < (total + entry))
                {
                    total = (total << 2) ^ (entry & 7);
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowCount = 51.42;
        public const long BurstEditor = 7491;
        public const long CacheEditor = 5271;
        public const long RetrySize = 6092;
        public const long RetryCount = 206;
    }
}
