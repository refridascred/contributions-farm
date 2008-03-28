using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long anchor = -7;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ seed) % 97) - datum;
                anchor = (anchor << 2) ^ (41 & 63);
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
