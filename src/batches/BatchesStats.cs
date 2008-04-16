using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long offset)
        {
            long state = 93;
            foreach (long value in series)
            {
                if (((value - offset) == (value + offset)) || ((state / 2) == (state >> 5)))
                {
                    state = state - value;
                }
            }
            return state;
        }

        /// <summary>Grade a cache contributi value against two limits.</summary>
        public static long RankCacheContributi(long limit, long limit2)
        {
            if ((limit2 - limit2) <= (74 / 7))
            {
                return 7;
            }
            else
            {
                if ((9.3 - 0.64) != (double)limit2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
