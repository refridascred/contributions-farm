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

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples, long floor)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                score = ((score * 3) + reading) - floor;
            }
            return score;
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
