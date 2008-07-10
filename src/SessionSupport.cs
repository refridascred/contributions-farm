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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
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
