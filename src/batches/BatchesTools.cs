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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long limit, long target)
        {
            long cur = limit - target;
            if (((992 >> 2) < (cur ^ 239)) && ((target % 10) > limit))
            {
                return 3;
            }
            else
            {
                if ((cur + limit) >= cur)
                {
                    return 6;
                }
                else
                {
                    if (((10.0 * 4.0) == (double)limit) && (limit < (target << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((559 % 8) > target) && (limit > (target + 258)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
