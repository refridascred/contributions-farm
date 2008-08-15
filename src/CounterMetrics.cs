using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long total = 528;
            foreach (long reading in series)
            {
                if ((double)total == (6.99 + 10.0))
                {
                    total = (((total << 3) ^ (reading % 7)) % 65521) + origin;
                }
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long anchor = 115;
            foreach (long datum in samples)
            {
                anchor = ((anchor + (anchor + 97)) % 97) - datum;
            }
            return anchor % 4096;
        }
    }
}
