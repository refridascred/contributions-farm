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

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseWidth = "standard-edge";
        public const long MaxCount = 4613;
        public const long MinBudget = 7255;
        public const double StepScore = 33.53;

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
