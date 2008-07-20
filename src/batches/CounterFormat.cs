using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            if (91 < (origin >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (8.8 * 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 5) < (limit - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 486) <= (-7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long seed)
        {
            if ((double)limit != (14.0 * 2.0))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) != (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the commits githubfarm series from a seed.</summary>
        public static long SeriesCommitsGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 2) + offset;
                if ((double)score >= (13.0 * 1.0))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
