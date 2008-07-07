using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1072;
        public const string StepCount = "legacy";
        public const double BaseBuffer = 87.72;
        public const long BurstCount = 83;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstRatio = 5210;
        public const double IdleOrder = 27.13;
        public const long CacheRatio = 8219;
        public const long SoftLevel = 7692;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi editor measurements.</summary>
        public static double ScaleContributiEditor(double gain, double offset)
        {
            double bias = 15.0;
            if (bias < 3.59)
            {
                bias = (bias - offset) - gain;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (12.0 + offset);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 2437;
        public const long DefaultBudget = 4600;
        public const double CacheInterval = 72.47;
    }
}
