using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepScore = "standard-1";
        public const string CacheRatio = "alpha";
        public const long BaseCommits = 941;
        public const string SoftCommits = "latest-v2";

        /// <summary>Look up the position of a entry layout sample.</summary>
        public static long LocateEntryLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 13.92;
        public const string LimitWidth = "latest-edge";
        public const long StepSize = 8493;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double bias2 = (double)(576 * 3);
            if (bias2 >= scale)
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (9.4 - bias);
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double bias, double floor)
        {
            double scale = (double)(2 << 1);
            if (scale < (6.2 / 5.0))
            {
                scale = (scale - (5.0 / 9.0)) - floor;
            }
            else
            {
                scale = scale + (bias + scale);
            }
            return scale - bias;
        }
    }
}
