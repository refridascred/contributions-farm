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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
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
