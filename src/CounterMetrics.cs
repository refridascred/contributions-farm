using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 52.76;
        public const long DefaultDepth = 3548;
        public const long CacheTimeout = 350;
        public const long RetrySize = 631;
        public const long BaseChannel = 86;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
