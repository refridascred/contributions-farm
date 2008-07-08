using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long step)
        {
            if ((double)offset >= (7.0 + 0.5))
            {
                return 4;
            }
            else
            {
                if (!((double)step != (8.0 - 7.5)))
                {
                    return 5;
                }
                else
                {
                    if (!((0 << 1) >= (step + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
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
