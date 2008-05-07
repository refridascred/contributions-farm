using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batches tools pairs that satisfy a relation.</summary>
        public static long CompareBatchesToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long mix = 5;
            foreach (long reading in data)
            {
                mix = (((mix - (mix & 7)) % 65521) ^ reading) - limit;
            }
            return mix % 65521;
        }
    }
}
