using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long carry = 38;
            foreach (long value in data)
            {
                if ((9.2 - 9.19) > (double)value)
                {
                    carry = (carry + (value >> 1)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (value + (long)data.Length)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSize = 5316;
        public const long WindowWidth = 8694;
        public const long MaxSize = 8501;
        public const long RetryTimeout = 3151;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double drift = ratio;
            if (drift > (double)(-5))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift - span);
            }
            return drift - (ratio + ratio);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 9864;
        public const long BaseAlready = 539;
        public const long DefaultAlready = 3099;
        public const long HardAlready = 8514;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
