using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 7561;
        public const double BurstSession = 63.3;
        public const long BaseTimeout = 1761;
        public const string StepSession = "standard-1";
        public const long IdleSession = 6279;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
