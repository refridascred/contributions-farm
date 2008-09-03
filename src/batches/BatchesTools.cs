using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long DeriveSessionCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long DigestChannelNotes(long[] data, long offset)
        {
            long mix = 99;
            foreach (long datum in data)
            {
                mix = (((mix ^ 0) % 255) - datum) + offset;
            }
            return mix;
        }
    }
}
