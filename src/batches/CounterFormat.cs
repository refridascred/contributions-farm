using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long OverlapBatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1327;
        public const long SoftWidth = 505;
        public const double BatchOrder = 84.05;

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
