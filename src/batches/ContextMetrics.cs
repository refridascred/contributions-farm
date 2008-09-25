using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double gain = rate;
            if (gain < (gain * 4.0))
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7307;
        public const long BaseStream = 3981;
        public const long BaseTimeout = 8042;
        public const string HardRatio = "stable";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long origin)
        {
            if ((limit > (origin * 3)) && ((limit % 12) >= (limit ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) < limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
