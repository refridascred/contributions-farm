using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)13 * 5.9;
            if (ratio <= floor)
            {
                ratio = (ratio - (double)0) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)626;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
