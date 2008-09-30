using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long MeasureGithubfarmChecksOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset << 2) > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (scale / 3.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (offset + scale)) + (double)(long)i;
            }
            return scale2 + (double)969;
        }

        /// <summary>Grade a window tools value against two limits.</summary>
        public static long GradeWindowTools(long bound, long offset)
        {
            if ((double)offset > (1.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if (8 > bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset % 7) >= (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
