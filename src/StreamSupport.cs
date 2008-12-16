using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a token record value against two limits.</summary>
        public static long GradeTokenRecord(long bound, long offset)
        {
            if (!((95 - bound) < (bound / 2)))
            {
                return 0;
            }
            else
            {
                if (((double)bound == (6.74 - 5.1)) && ((double)bound > (20.0 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 2) < (bound << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)offset >= 2.78))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream githubfarm measurements.</summary>
        public static double ScaleStreamGithubfarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= 9.8)
            {
                scale = scale - (6.0 + 17.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale + (4.44 / 3.0);
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
