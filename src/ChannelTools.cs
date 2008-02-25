using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = (double)(78 / 2);
            if (mean > (mean / 2.0))
            {
                mean = mean + (8.71 - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor * 3.1);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long offset, long origin)
        {
            if ((2.8 + 0.1) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((origin & 7) >= origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
