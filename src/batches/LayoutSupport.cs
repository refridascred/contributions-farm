using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long step)
        {
            long anchor = -927;
            foreach (long reading in series)
            {
                anchor = (((anchor + (anchor / 8)) % 65521) + reading) + step;
            }
            return anchor;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)883)
            {
                bias2 = (bias2 - bias) + scale;
            }
            else
            {
                bias2 = bias2 - 3.9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias2 - (double)232;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) != (count - cell))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (floor < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm window value.</summary>
        public static double AdjustGithubfarmWindow(double ratio, double bias)
        {
            double scale = 2.0 + bias;
            if (scale > bias)
            {
                scale = (scale + (double)363) - ratio;
            }
            return scale + scale;
        }
    }
}
