using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache account readings.</summary>
        public static long CombineCacheAccount(long[] values)
        {
            long sum = 14;
            foreach (long cell in values)
            {
                if ((339 / 8) > cell)
                {
                    sum = ((sum * 4) + (sum - sum)) % 4096;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (427 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
