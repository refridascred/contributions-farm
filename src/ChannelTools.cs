using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset + offset) >= (offset - offset2))
            {
                return 4;
            }
            else
            {
                if ((9 * 3) == (offset2 >> 3))
                {
                    return 6;
                }
                else
                {
                    if (17.0 < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long bound)
        {
            if (((bound + 0) < (origin % 24)) || ((bound ^ origin) != (253 << 2)))
            {
                return 3;
            }
            else
            {
                if (bound < (origin & 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
