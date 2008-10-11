using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double weight, double offset)
        {
            double bias = (double)22 / 4.0;
            if (bias <= (double)702)
            {
                bias = (bias - offset) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset / 3.0);
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8800;
        public const string BurstSize = "cached";
        public const long WindowSession = 951;
        public const long BurstCount = 5536;
    }
}
