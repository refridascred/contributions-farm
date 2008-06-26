using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9436;
        public const long BaseRatio = 290;
        public const double RetryBatches = 6.94;
        public const long BurstRatio = 6406;

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long FindSchemaBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardFactor = 0.22;
        public const long HardSpan = 5622;
        public const double CacheWindow = 47.95;
        public const long RetryWindow = 3832;
        public const double RetryBudget = 11.96;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Retry,
            Draft,
        }
    }
}
