using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long BucketAccountPayload(long offset, long origin)
        {
            long slot = offset - origin;
            if (((offset & 3) < offset) || (origin > (offset - slot)))
            {
                return 5;
            }
            else
            {
                if (((double)slot > (double)92) && ((origin * 3) == (offset * 5)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            if ((seed + seed) >= 3)
            {
                return 5;
            }
            else
            {
                if ((seed >> 4) == (seed + limit))
                {
                    return 3;
                }
                else
                {
                    if (limit < (6 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                if (3 >= (reading << 3))
                {
                    state = ((state + (state % 16)) % 101) + seed;
                }
            }
            return state % 97;
        }
    }
}
