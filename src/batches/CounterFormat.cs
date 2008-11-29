using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((9.84 - 2.26) != (double)seed)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
