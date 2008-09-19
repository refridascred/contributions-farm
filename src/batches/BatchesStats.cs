using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long anchor = 10;
            foreach (long cell in levels)
            {
                if (((5.82 / 8.0) < (double)cell) && (anchor > (cell % 8)))
                {
                    anchor = (anchor + (anchor - 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Pending,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long TallyCommitsReport(long[] data)
        {
            long state = 4;
            foreach (long datum in data)
            {
                state = ((state * 5) + (state & 31)) + datum;
            }
            if (state < 38)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }
    }
}
