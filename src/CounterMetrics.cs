using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count commits counter pairs that satisfy a relation.</summary>
        public static long CompareCommitsCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (origin <= (origin & 15))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
