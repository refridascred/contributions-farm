using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSize = 9403;
        public const long LimitChecks = 9505;
        public const long HardChecks = 9881;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
