using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "strict-1";
        public const string WindowSpan = "cached-1";
        public const double MaxInterval = 14.09;
        public const long DefaultCounter = 1705;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double rate = scale / 6.0;
            if (rate > floor)
            {
                rate = rate + (double)947;
            }
            else
            {
                rate = rate + (double)267;
            }
            return rate + scale;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double weight = 8.8;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + offset;
            }
            return weight - weight;
        }
    }
}
