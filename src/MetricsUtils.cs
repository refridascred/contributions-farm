using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3173;
        public const long WindowSchema = 1268;
        public const string CacheSchema = "fallback-1";
        public const long CacheBudget = 5865;
        public const long BurstScore = 1435;

        /// <summary>Scale a filter already figure with a bias.</summary>
        public static double SmoothFilterAlready(double ratio, double floor)
        {
            double ratio2 = (double)(98 << 2);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (((ratio2 - (double)238) + (double)(long)i) + ratio) + floor;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            return scale - offset;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            New,
            Pending,
        }
    }
}
