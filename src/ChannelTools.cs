using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (double)92)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)30;
            }
            return bias2 + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 7224;
        public const string IdleGraph = "legacy-v2";
        public const long BurstFactor = 151;
        public const double MaxGraph = 60.87;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (target + target)) % 1000) ^ (long)i2;
                    acc = acc - (long)i;
                }
                acc = (acc + (acc ^ (long)i)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
