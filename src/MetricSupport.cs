using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools layout samples.</summary>
        public static long MatchToolsLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long acc = -78;
            foreach (long value in levels)
            {
                acc = (acc + acc) + value;
            }
            return acc;
        }
    }
}
