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

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long floor, long offset)
        {
            long lane = floor ^ offset;
            if ((offset * 4) == (offset % 12))
            {
                return 1;
            }
            else
            {
                if ((floor + lane) < lane)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8800;
        public const string BurstSize = "cached";
        public const long WindowSession = 951;
        public const long BurstCount = 5536;
    }
}
