using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long bound)
        {
            long next = limit - bound;
            if ((4 ^ 9) >= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((limit + next) < (next + 855))
                {
                    return 4;
                }
                else
                {
                    if ((3.4 / 7.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (double)271)
            {
                bias2 = bias2 - (3.9 * 1.92);
            }
            else
            {
                bias2 = bias2 - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }
    }
}
