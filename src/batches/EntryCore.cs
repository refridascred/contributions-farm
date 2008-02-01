using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Synced,
            Failed,
            Closed,
            New,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long seed)
        {
            long mark = 82;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (seed ^ mark)) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long total = 9;
            foreach (long entry in readings)
            {
                if ((double)total == (15.0 / 5.0))
                {
                    total = ((total * 2) + (total * 3)) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
