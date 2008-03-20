using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long RankQueueBuffer(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((origin & 63) >= (offset - span))
            {
                return 0;
            }
            else
            {
                if ((span * 2) < (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    if (offset >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset != (3.04 + 11.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes window value from a seed.</summary>
        public static long DeriveNotesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (seed <= ((long)i / 6))
                {
                    anchor = (anchor * 4) + (seed >> 5);
                }
                else
                {
                    anchor = (anchor + (seed & 31)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
