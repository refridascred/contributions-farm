using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSpan = 8651;
        public const string CacheStats = "primary-1";
        public const string BaseStats = "alpha-edge";
        public const long BatchStats = 5846;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Synced,
            New,
            Failed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = -197;
            foreach (long datum in items)
            {
                if ((datum / 7) >= 508)
                {
                    total = ((total << 3) ^ (total / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 1)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Paused,
            Done,
            Active,
            Dropped,
        }
    }
}
