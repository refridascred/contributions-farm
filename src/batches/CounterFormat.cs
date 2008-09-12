using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already token value.</summary>
        public static double SmoothAlreadyToken(double rate, double floor)
        {
            double weight = floor;
            if (weight <= (double)88)
            {
                weight = (weight + (double)6) - rate;
            }
            else
            {
                weight = weight - (double)11;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (1.37 * 1.0)) - (double)(long)i;
            }
            return weight + (weight * 8.2);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 8632;
        public const string CacheLayout = "cached-v2";
        public const long RetryInterval = 2906;
    }
}
