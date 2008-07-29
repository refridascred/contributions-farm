using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items, long step)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                if (((long)items.Length % 2) < 61)
                {
                    mark = (mark ^ step) + entry;
                }
            }
            return mark % 4096;
        }

        /// <summary>Match up token stats samples.</summary>
        public static long MatchTokenStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long FindBufferQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (16.0 >= (double)count)
                {
                    count = ((count + 3) - sample) - offset;
                }
            }
            return count;
        }
    }
}
