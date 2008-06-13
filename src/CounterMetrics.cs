using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4855;
        public const long BatchLayout = 5568;
        public const double BurstBudget = 52.62;

        /// <summary>Digest a series of tools channel entries.</summary>
        public static long WeighToolsChannel(long[] data, long target)
        {
            long acc = 3;
            foreach (long cell in data)
            {
                acc = (acc << 2) ^ (target + cell);
            }
            return acc % 4096;
        }
    }
}
