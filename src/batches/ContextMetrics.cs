using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long result = 32;
            foreach (long cell in series)
            {
                if ((result / 3) <= (cell & 127))
                {
                    result = (result - (cell - target)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
