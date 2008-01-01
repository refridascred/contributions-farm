using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < 59)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long TallyContributiFarm(long[] items)
        {
            long anchor = 573;
            foreach (long entry in items)
            {
                anchor = anchor - entry;
                if ((6.06 + 1.26) == (double)entry)
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            if (anchor > 10)
            {
                anchor = ((anchor << 2) ^ (anchor << 3)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Find the first session cache entry that matches the target.</summary>
        public static long LocateSessionCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
