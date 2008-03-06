using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (seen ^ 937))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
