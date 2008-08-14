using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items)
        {
            long mix = 680;
            foreach (long reading in items)
            {
                if ((mix ^ 949) >= (reading - mix))
                {
                    mix = ((mix << 2) ^ (reading + reading)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long seed)
        {
            long offset = origin - seed;
            if ((31 - offset) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) > (458 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin >= 9.56) || ((double)offset != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((841 < (offset + origin)) || ((seed + offset) > (origin + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
