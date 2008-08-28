using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series, long origin)
        {
            long sum = 319;
            foreach (long cell in series)
            {
                if (1 < (cell / 7))
                {
                    break;
                }
                sum = sum - (82 / 4);
                sum = (sum ^ (origin + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long AuditEditorEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits < 7.9)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
