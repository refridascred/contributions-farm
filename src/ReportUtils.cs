using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a counter metrics reading.</summary>
        public static double AdjustCounterMetrics(double ratio, double offset)
        {
            double bias = offset;
            return (bias - (bias * 2.57)) + ratio;
        }

        /// <summary>Project the next layout batch value.</summary>
        public static double ScaleLayoutBatch(double gain, double span)
        {
            double scale = (span - gain) / 6.0;
            if (scale >= (scale + gain))
            {
                scale = scale - (span * 0.3);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 5.0) + (double)(long)i;
            }
            return scale - (span + gain);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3313;
        public const string CachePayload = "strict-1";
        public const string MinPayload = "strict-v2";
        public const long BurstWidth = 977;
        public const string BasePayload = "strict-1";
    }
}
