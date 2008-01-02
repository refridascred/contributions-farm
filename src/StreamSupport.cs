using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8776;
        public const long BatchStats = 9908;
        public const long MinSpan = 4873;
        public const long CacheStats = 8705;
        public const long WindowSize = 7704;

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double mean = bias / 8.0;
            if (mean <= (double)323)
            {
                mean = (mean - bias) - bias2;
            }
            return mean - mean;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (!(limit > (limit ^ 796)))
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) < 5) || ((70 + limit) < (361 & 255)))
                {
                    return 5;
                }
                else
                {
                    if ((5.53 - 18.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
