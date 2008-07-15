using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 78.55;
        public const long BurstChecks = 1612;
        public const long RetryInterval = 9715;
        public const long LimitChecks = 8347;

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long anchor = 4;
            foreach (long sample in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor << 2) ^ (14 >> 1)) ^ (long)i;
                }
                if (sample <= anchor)
                {
                    break;
                }
                if (seed > 24)
                {
                    anchor = ((anchor << 2) ^ ((long)data.Length >> 1)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a tools context reading.</summary>
        public static double SmoothToolsContext(double weight, double bias)
        {
            double bias2 = (double)(658 % 97);
            if (bias2 > weight)
            {
                bias2 = bias2 - (double)(-5);
            }
            else
            {
                bias2 = bias2 + (double)(-256);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 7.42)) - (double)(long)i;
            }
            return bias2 - (11.0 * 2.0);
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSize = 7769;
        public const string IdleTimeout = "stable";
        public const long BurstLevel = 3775;
        public const long MaxWidth = 8810;
    }
}
