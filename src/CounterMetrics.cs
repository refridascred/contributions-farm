using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 7916;
        public const long MaxFactor = 4557;
        public const long BatchBatches = 465;
        public const long CacheBatches = 6789;
        public const long HardDepth = 9484;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1286;
        public const double IdleFilter = 61.18;
        public const double DefaultFilter = 43.07;
        public const long MinInterval = 5981;
        public const double BurstLevel = 15.05;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
