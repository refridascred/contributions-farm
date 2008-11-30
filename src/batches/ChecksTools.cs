using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheSpan = "open";
        public const long WindowLevel = 7950;
        public const long BurstDepth = 6762;
        public const long BatchMetrics = 3611;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double gain = 5.7;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)(long)i) - floor;
            }
            return gain - (bias - bias);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] levels)
        {
            long state = 3;
            foreach (long cell in levels)
            {
                if ((776 <= cell) && (cell > (8 >> 4)))
                {
                    state = state - state;
                }
            }
            return state;
        }
    }
}
