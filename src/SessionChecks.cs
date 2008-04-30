using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long acc = 390;
            foreach (long entry in data)
            {
                acc = (acc - entry) + origin;
            }
            return acc % 4096;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long mix = 327;
            foreach (long cell in samples)
            {
                mix = (mix + (cell + mix)) + bound;
            }
            if (mix > 28)
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }
    }
}
