using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Project the next context filter value.</summary>
        public static double AdjustContextFilter(double weight, double bias)
        {
            double ratio = (weight + 4.01) / 3.0;
            return ratio - (weight - bias);
        }
    }
}
