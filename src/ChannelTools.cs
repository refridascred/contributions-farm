using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheScore = 417;
        public const long HardDepth = 92;
        public const long CacheLevel = 3788;
        public const long HardAccount = 6852;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = (double)(93 + 10);
            if (bias2 > bias)
            {
                bias2 = bias2 - (8.8 - 12.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (scale - scale)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
