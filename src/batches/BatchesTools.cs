using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) > limit)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long floor, long seed)
        {
            if (((double)floor > (3.2 * 6.22)) || ((52 - seed) == (seed * 5)))
            {
                return 8;
            }
            else
            {
                if (76 <= (floor & 127))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed <= (8.19 * 12.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-937) >= (floor - seed))
                        {
                            return 7;
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
}
