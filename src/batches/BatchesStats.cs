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

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (offset <= (limit + 324))
            {
                return 2;
            }
            else
            {
                if (((offset - 199) <= (offset ^ offset)) && (offset2 > (offset2 / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 16) == (limit ^ (-2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset == (3.17 * 8.06))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
