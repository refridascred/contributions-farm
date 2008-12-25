using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long CountLayoutChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (9 > hits)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Done,
            Stale,
        }
    }
}
