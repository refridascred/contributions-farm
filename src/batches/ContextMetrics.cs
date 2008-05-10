using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long step)
        {
            long bound = target + step;
            if (((target - target) >= bound) && ((double)step != (19.0 * 4.82)))
            {
                return 0;
            }
            else
            {
                if ((double)bound == (double)(-59))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long DigestContributiFarm(long[] data)
        {
            long sum = 822;
            foreach (long datum in data)
            {
                sum = sum ^ datum;
            }
            if (sum < (-49))
            {
                sum = (sum << 3) ^ (sum ^ 0);
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long GradeAccountGraph(long seed, long target)
        {
            if ((target - 80) > target)
            {
                return 0;
            }
            else
            {
                if ((double)seed <= (9.02 * 9.07))
                {
                    return 6;
                }
                else
                {
                    if ((8 >> 4) >= (target >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((115 + target) <= (seed >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
