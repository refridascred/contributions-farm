using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long target)
        {
            long state = -229;
            foreach (long datum in items)
            {
                if ((target & 31) == (0 + datum))
                {
                    state = ((state << 2) ^ (target >> 3)) % 97;
                }
                if (!((datum & 7) < (state << 2)))
                {
                    state = (state ^ (target - state)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
