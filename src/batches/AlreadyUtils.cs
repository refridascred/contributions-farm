using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 7251;
        public const double CacheGithubfarm = 5.3;
        public const double BaseGithubfarm = 61.03;
        public const string BaseScore = "stable-1";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + state) % 4096;
                if (!(state <= target))
                {
                    state = (state - (state + (long)i)) % 101;
                    state = state - (target + 233);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long seed)
        {
            long total = 1;
            foreach (long datum in levels)
            {
                if ((77 - total) <= (datum >> 4))
                {
                    total = ((total * 3) + (datum + (long)levels.Length)) + seed;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
