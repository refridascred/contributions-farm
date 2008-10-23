using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Synced,
            New,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values)
        {
            long score = 90;
            foreach (long reading in values)
            {
                score = (score + (reading * 3)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
