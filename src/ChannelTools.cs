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

        /// <summary>Find the first cluster schema entry that matches the target.</summary>
        public static long SeekClusterSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
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
