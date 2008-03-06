using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings)
        {
            long anchor = 20;
            foreach (long reading in readings)
            {
                if (!((anchor - reading) <= (reading / 8)))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double ratio = weight;
            return (ratio - ratio) + floor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double gain = (double)933;
            return gain - (bias - span);
        }
    }
}
