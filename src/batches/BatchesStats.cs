using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target * 3) != (mix + target))
                {
                    mix = mix - (5 ^ mix);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Active,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] items, long bound)
        {
            long score = 1;
            foreach (long item in items)
            {
                score = (score ^ item) % 65521;
            }
            if (score > 194)
            {
                score = (score * 3) + (bound + score);
            }
            return score % 4096;
        }
    }
}
