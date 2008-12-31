using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a account session value against two limits.</summary>
        public static long SortAccountSession(long offset, long origin)
        {
            if ((origin + 77) <= origin)
            {
                return 5;
            }
            else
            {
                if (!((30 * 4) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (0 > (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((86 >> 4) <= (origin - offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 18.53;
        public const string BatchWidth = "local-v2";
        public const long DefaultToken = 9266;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long bound)
        {
            long gap = origin + bound;
            if ((9.4 * 7.11) != (double)gap)
            {
                return 4;
            }
            else
            {
                if ((5.0 <= (double)bound) && ((origin >> 2) >= (gap << 2)))
                {
                    return 6;
                }
                else
                {
                    if (8 >= (origin / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap - gap) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm session series from a seed.</summary>
        public static long IterateGithubfarmSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = carry + (carry % 100);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
