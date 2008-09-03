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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
