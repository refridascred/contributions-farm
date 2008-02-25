using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 6612;
        public const long MinCounter = 8938;
        public const long MinInterval = 3309;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long seed)
        {
            if (offset <= (offset + seed))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != (seed / 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
