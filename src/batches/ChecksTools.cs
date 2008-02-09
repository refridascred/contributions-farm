using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double ratio = 6.5;
            if (ratio >= (5.15 / 4.0))
            {
                ratio = (ratio + ratio) + bias;
            }
            else
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias2) + (double)(long)i;
            }
            return ratio + 9.4;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double rate, double floor)
        {
            double bias = (double)((-991) * 4);
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + rate) - (double)(long)i) - floor;
            }
            return bias - 2.1;
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long LocateChannelMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 875;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum >> 3)) - reading;
            }
            return sum;
        }
    }
}
