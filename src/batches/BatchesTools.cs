using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long origin)
        {
            if ((origin & 63) > origin)
            {
                return 2;
            }
            else
            {
                if (offset < (origin ^ 177))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 3) <= (offset % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
