using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long acc = -293;
            foreach (long reading in items)
            {
                if ((13.0 / 7.0) <= (double)acc)
                {
                    acc = ((acc - (acc * 4)) % 101) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "primary-edge";
        public const double CacheCount = 71.45;
        public const long LimitFactor = 6632;
        public const double LimitSize = 75.23;
        public const long WindowAlready = 8977;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 6396;
        public const long DefaultBatches = 3170;
        public const long LimitBatches = 7998;
        public const long CacheBatches = 5633;
        public const string DefaultBudget = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long StepTimeout = 6207;
        public const long MaxSupport = 2832;
        public const long MaxLevel = 8878;
        public const double HardSupport = 45.8;
    }
}
