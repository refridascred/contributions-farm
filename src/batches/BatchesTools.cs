using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (3.0 >= (double)slot)
            {
                return 8;
            }
            else
            {
                if (((4.19 + 20.0) == (double)seed2) || (127 <= (seed2 / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 < 15.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 >= slot) || ((seed2 & 255) <= (-327)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long mark = 541;
            foreach (long entry in samples)
            {
                mark = ((mark ^ ((-30) << 3)) % 65521) + entry;
            }
            if (mark < (-3))
            {
                mark = (mark * 2) + (mark + seed);
            }
            return mark;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Active,
            Paused,
            Draft,
            Ready,
        }
    }
}
