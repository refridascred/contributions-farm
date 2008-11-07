using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch payload value.</summary>
        public static double ProjectBatchPayload(double weight, double offset)
        {
            double drift = offset - (weight / 6.0);
            if (drift > (double)2)
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryLevel = 5.43;
        public const double CacheBudget = 36.2;
        public const long SoftWindow = 9590;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Active,
            Retry,
            Dropped,
            Stale,
        }
    }
}
