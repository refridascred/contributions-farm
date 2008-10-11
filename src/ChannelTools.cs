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

        /// <summary>Fold a list of route command readings.</summary>
        public static long DigestRouteCommand(long[] levels, long seed)
        {
            long mix = -3;
            foreach (long entry in levels)
            {
                if (!((seed ^ seed) > entry))
                {
                    mix = (mix << 2) ^ (mix / 9);
                }
            }
            return mix % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8800;
        public const string BurstSize = "cached";
        public const long WindowSession = 951;
        public const long BurstCount = 5536;
    }
}
