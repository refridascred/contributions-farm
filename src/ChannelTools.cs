using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + sum) != (floor + sum)) && ((double)(long)i <= (6.57 - 3.39)))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a payload route pair into a bucket.</summary>
        public static long SortPayloadRoute(long target, long bound)
        {
            if ((target - 6) > bound)
            {
                return 6;
            }
            else
            {
                if (bound < (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if (target < (target + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
