using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleTimeout = "staging-v2";
        public const string CacheBudget = "alpha-edge";
        public const long IdleGithubfarm = 4217;
        public const long BatchWidth = 7330;
        public const long BaseGithubfarm = 6391;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((3.18 * 0.12) > (3.0 / 4.0))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster commits pair into a bucket.</summary>
        public static long BucketClusterCommits(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((limit >= prev) && ((double)prev > 6.23))
            {
                return 7;
            }
            else
            {
                if ((prev ^ limit) < (prev & 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
