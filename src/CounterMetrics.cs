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

        /// <summary>Compare every pair of cluster channel readings.</summary>
        public static long PairClusterChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
