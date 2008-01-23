using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long sum = 338;
            foreach (long cell in readings)
            {
                sum = sum ^ (sum - sum);
                sum = ((sum * 3) + (cell + sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 9402;
        public const long SoftCount = 3983;
        public const string DefaultWidth = "standard";
        public const double StepScore = 98.9;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
