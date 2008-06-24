using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (5.2 / 4.0))
            {
                bias = bias + (offset * 7.93);
            }
            else
            {
                bias = bias - (1.16 / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)0) + (double)(long)i;
            }
            return bias + 5.61;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item > (matches & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long seed)
        {
            if ((717 + offset) == (offset >> 4))
            {
                return 1;
            }
            else
            {
                if ((seed - 28) <= (offset - 67))
                {
                    return 3;
                }
                else
                {
                    if (!((6.25 + 9.73) == (double)seed))
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
}
