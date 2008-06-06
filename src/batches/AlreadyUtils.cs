using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 6800;
        public const double LimitFactor = 15.17;
        public const long CacheEntry = 2315;
        public const string DefaultEntry = "staging-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 52.84;
        public const long MaxRatio = 5976;
        public const long CacheQueue = 1733;

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values, long limit)
        {
            long carry = 26;
            foreach (long value in values)
            {
                if (((carry / 7) <= limit) || ((carry - limit) < carry))
                {
                    carry = (carry * 3) + (448 >> 4);
                }
                if (((486 >> 3) != (value ^ value)) || ((7 - limit) <= (-31)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= (floor * 11.0))
            {
                ratio = ratio - (bias * 3.19);
            }
            return ratio - bias;
        }
    }
}
