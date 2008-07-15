using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Closed,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) >= ((long)samples.Length ^ step))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] values)
        {
            long anchor = 24;
            foreach (long sample in values)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) ^ sample;
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }
    }
}
