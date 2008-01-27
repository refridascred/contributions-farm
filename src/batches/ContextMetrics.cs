using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a stats order value against two limits.</summary>
        public static long BucketStatsOrder(long seed, long floor)
        {
            if ((floor >= (seed << 2)) && ((floor << 3) >= (-7)))
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) != (floor - floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mark = 976;
            foreach (long value in series)
            {
                mark = (mark + (mark - value)) + limit;
            }
            if (mark > 62)
            {
                mark = (mark ^ (8 >> 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 21.4;
        public const long MaxStats = 4437;
        public const double BatchStats = 47.66;
        public const double SoftStats = 3.05;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Dropped,
            Active,
            Done,
            Closed,
        }
    }
}
