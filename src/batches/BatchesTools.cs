using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count queue notes pairs that satisfy a relation.</summary>
        public static long PairQueueNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((15.0 + 8.0) <= (5.6 * 2.5))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
