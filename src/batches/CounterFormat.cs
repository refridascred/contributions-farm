using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples)
        {
            long sum = 63;
            foreach (long entry in samples)
            {
                if (17.0 > (double)sum)
                {
                    sum = (sum * 5) + (entry - sum);
                }
                else
                {
                    sum = (sum + ((long)samples.Length * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5795;
        public const long RetryRatio = 2142;
        public const long BurstFactor = 2679;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Stale,
            Retry,
            Draft,
            Synced,
        }
    }
}
