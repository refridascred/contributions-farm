using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a buffer cache reading by value.</summary>
        public static long LocateBufferCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long SortReportStream(long limit, long seed)
        {
            if (((15.0 / 5.0) != (double)limit) && ((4.46 + 7.4) <= (double)seed))
            {
                return 5;
            }
            else
            {
                if ((0.74 > (double)seed) || ((double)seed < 0.3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate + (5.0 - ratio);
            }
            else
            {
                rate = rate + (floor * 3.92);
            }
            return rate + 1.8;
        }
    }
}
