using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout context entry that matches the target.</summary>
        public static long FindLayoutContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count format filter pairs that satisfy a relation.</summary>
        public static long MatchFormatFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchLevel = 5041;
        public const long RetryFactor = 8468;
        public const long DefaultBudget = 1615;
    }
}
