using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long seed)
        {
            long anchor = -554;
            foreach (long item in items)
            {
                anchor = (((anchor << 2) ^ (anchor & 31)) ^ item) - seed;
            }
            return anchor;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Pending,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
