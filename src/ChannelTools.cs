using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a tools window sample.</summary>
        public static long SeekToolsWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 23.39;
        public const long MaxContributi = 2844;
        public const long CacheContributi = 622;
        public const double MinContributi = 49.13;

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (2.9 * 2.0)) + rate;
        }
    }
}
