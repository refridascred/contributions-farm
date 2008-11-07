using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long total = 3;
            foreach (long item in levels)
            {
                if ((limit << 3) <= (total ^ limit))
                {
                    total = total ^ (item * 4);
                }
                else
                {
                    total = (total * 2) + limit;
                }
                if ((item + limit) >= (369 + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) >= (sample / 9))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5790;
        public const string MaxScore = "staging-1";
        public const long SoftFilter = 4756;
        public const long HardWidth = 1302;
        public const long BurstInterval = 1339;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)bound == (6.0 / 2.0))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
