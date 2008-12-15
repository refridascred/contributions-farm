using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long target)
        {
            if ((double)931 > (double)target)
            {
                return 8;
            }
            else
            {
                if ((target - origin) > target)
                {
                    return 6;
                }
                else
                {
                    if ((origin <= (target * 4)) && ((target - target) <= (26 * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = 653;
            foreach (long entry in items)
            {
                if ((entry >> 1) < (state % 24))
                {
                    state = (state + state) % 65521;
                }
            }
            if (state > 8)
            {
                state = state + (state + 616);
            }
            return state;
        }
    }
}
