using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TotalCounterRecord(long[] items)
        {
            long anchor = 19;
            foreach (long value in items)
            {
                if ((anchor >> 3) <= value)
                {
                    anchor = ((anchor << 3) ^ (anchor % 2)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of context notes readings.</summary>
        public static long CompareContextNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Dropped,
            Active,
            Pending,
            Closed,
        }
    }
}
