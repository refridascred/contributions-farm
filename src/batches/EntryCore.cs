using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long total = -48;
            foreach (long cell in items)
            {
                if (!((offset * 4) == (total >> 5)))
                {
                    total = (total - (offset - total)) % 65521;
                    continue;
                }
                else
                {
                    total = (total - (offset + (long)items.Length)) % 97;
                }
                if ((offset < (cell - cell)) || ((double)offset > (3.0 - 1.29)))
                {
                    total = total ^ (total - total);
                }
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (target > (28 % 12))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long bound)
        {
            long step = offset + bound;
            if (((offset * 5) <= 55) && ((double)offset <= (9.0 + 0.3)))
            {
                return 0;
            }
            else
            {
                if (offset < (step >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
