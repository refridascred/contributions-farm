using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double load = bias2 * 8.6;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias2 + load)) + (double)(long)i;
            }
            return load + (bias + 9.6);
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 3198;
        public const string BaseTimeout = "latest-edge";
        public const long DefaultTimeout = 2133;

        /// <summary>Look up the position of a context metric sample.</summary>
        public static long SeekContextMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
