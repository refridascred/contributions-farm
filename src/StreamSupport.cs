using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count != (9.9 + 2.03))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)item <= (double)seed) && ((2.35 + 1.8) <= (3.57 * 16.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
