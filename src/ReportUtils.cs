using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a batch tools reading by value.</summary>
        public static long LookupBatchToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double gain2 = 6.38;
            if (gain2 >= gain)
            {
                gain2 = (gain2 - gain2) + bias;
            }
            else
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain - gain);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheSpan = 3.45;
        public const string LimitOrder = "local-1";
        public const string BurstCount = "latest-edge";
        public const string BatchOrder = "latest-v2";
        public const string IdleSpan = "staging";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (5.3 / 4.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
