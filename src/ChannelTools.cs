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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value * 3) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8800;
        public const string BurstSize = "cached";
        public const long WindowSession = 951;
        public const long BurstCount = 5536;
    }
}
