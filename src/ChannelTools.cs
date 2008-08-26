using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double gain = (double)(6 >> 1);
            if (gain > (rate + floor))
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long IterateMetricsWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 4) + ((long)i + total);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
