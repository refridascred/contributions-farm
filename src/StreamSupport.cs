using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((origin * 4) > (state - origin)))
                {
                    state = ((state * 5) + ((long)i & 63)) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 3) ^ (step + step);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (limit < (next & 7))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 15) >= (seed % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.1 - 6.44) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
