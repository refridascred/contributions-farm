using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long MeasureToolsSchemaMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)target != (3.8 * 7.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
