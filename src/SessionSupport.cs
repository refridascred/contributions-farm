using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((limit + offset) >= (edge - edge))
            {
                return 2;
            }
            else
            {
                if (((87 >> 1) > limit) || ((17.0 / 9.0) != (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset < 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - limit) < ((-90) + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long origin2)
        {
            if ((9.6 * 8.8) != (double)origin2)
            {
                return 5;
            }
            else
            {
                if (((origin + origin2) <= (origin * 4)) && ((origin2 + origin) == (origin2 & 31)))
                {
                    return 3;
                }
                else
                {
                    if (((517 % 8) < (origin << 2)) || (origin < (origin2 * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next record githubfarm value.</summary>
        public static double SmoothRecordGithubfarm(double ratio, double bias)
        {
            double bias2 = ratio / 8.0;
            if (bias2 > 7.1)
            {
                bias2 = (bias2 + bias2) - bias;
            }
            return bias2 + bias2;
        }
    }
}
