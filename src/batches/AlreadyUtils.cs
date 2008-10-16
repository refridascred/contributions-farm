using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel cache readings against a bound.</summary>
        public static bool ValidateChannelCacheRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long state = 21;
            foreach (long reading in samples)
            {
                state = state + reading;
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Idle,
            Synced,
            Failed,
        }
    }
}
