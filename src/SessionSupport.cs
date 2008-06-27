using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long offset, long offset2)
        {
            if (((offset2 / 7) >= (offset >> 2)) && (3.8 < (double)offset2))
            {
                return 8;
            }
            else
            {
                if (offset > (offset + offset2))
                {
                    return 3;
                }
                else
                {
                    if (offset2 < (offset2 / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((7.59 + 1.82) >= (double)offset2) || ((double)offset2 <= (2.9 + 8.63)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark * 5) + ((long)i ^ mark)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Stale,
            Ready,
            New,
            Paused,
        }
    }
}
