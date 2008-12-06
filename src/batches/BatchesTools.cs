using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long target)
        {
            if ((9.8 * 2.3) != (double)target)
            {
                return 6;
            }
            else
            {
                if (target < 2)
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 3) > 6)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            New,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long seed)
        {
            long acc = 87;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (sample >> 1)) + seed;
            }
            return acc;
        }
    }
}
