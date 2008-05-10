using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a counter token counter forward.</summary>
        public static long IterateCounterToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (limit >> 5)) % 97;
                if ((limit / 3) >= (limit % 16))
                {
                    anchor = (anchor ^ (limit >> 5)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
