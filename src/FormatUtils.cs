using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double offset)
        {
            double weight = gain / 4.0;
            if (weight <= (weight / 5.0))
            {
                weight = weight + (weight + 1.9);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + 6.33;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2352;
        public const string MinRoute = "alpha";
        public const long MaxRoute = 2676;
        public const double CacheTimeout = 12.32;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchFactor = 62.78;
        public const long CacheMetrics = 9580;
        public const long LimitDepth = 3133;
        public const long SoftMetrics = 7105;
        public const string IdleMetrics = "fallback";

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
