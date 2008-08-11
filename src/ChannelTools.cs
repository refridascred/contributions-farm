using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (ratio - offset))
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 1.4)) + (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Rank metrics report input into a small class.</summary>
        public static long ClassifyMetricsReport(long offset, long origin)
        {
            if ((double)origin >= (2.0 - 8.9))
            {
                return 6;
            }
            else
            {
                if (((-76) - origin) > (offset & 31))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
