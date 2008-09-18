using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long total = 258;
            foreach (long datum in samples)
            {
                if ((limit * 3) <= (limit * 2))
                {
                    total = ((total << 3) ^ (total & 31)) ^ datum;
                }
                else
                {
                    total = ((total * 4) + 2) % 1000;
                }
            }
            return total;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long seed)
        {
            long gap = limit + seed;
            if ((gap * 4) <= 14)
            {
                return 3;
            }
            else
            {
                if (((0 + seed) >= gap) && (seed > (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    if ((gap % 16) == (gap - (-410)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
