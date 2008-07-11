using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stream githubfarm value against two limits.</summary>
        public static long BucketStreamGithubfarm(long seed, long target)
        {
            if (((seed - 368) < seed) || ((seed - seed) <= 3))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((seed > (7 % 7)) || ((double)target == (2.56 - 17.0)))
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long BucketCachePayload(long target, long bound)
        {
            if ((target + bound) != (target >> 3))
            {
                return 7;
            }
            else
            {
                if ((53 / 9) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
