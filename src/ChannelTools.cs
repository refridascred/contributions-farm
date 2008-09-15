using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally << 2) < (tally ^ 0))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long step)
        {
            long gap = target ^ step;
            if ((target - step) >= (600 + 25))
            {
                return 6;
            }
            else
            {
                if (!((gap >> 2) != (394 - gap)))
                {
                    return 7;
                }
                else
                {
                    if (((step + step) >= (step << 1)) || ((step / 2) <= ((-9) << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double offset)
        {
            double gain2 = gain + gain;
            if (gain2 >= (gain - gain))
            {
                gain2 = gain2 + (offset / 7.0);
            }
            else
            {
                gain2 = gain2 + (gain2 + gain2);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain + offset)) - (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
