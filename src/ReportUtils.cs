using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (7.18 - bias) * 5.5;
            if (scale <= (scale / 8.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (bias / 5.0);
            }
            return scale + (9.6 * 19.0);
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long FindFarmSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 41.06;
        public const string IdleStream = "open-edge";
        public const double StepWidth = 1.25;
        public const string RetryCount = "strict-edge";
    }
}
