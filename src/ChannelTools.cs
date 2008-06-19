using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry % 2)) % 255;
                if ((7.76 / 4.0) < (double)acc)
                {
                    acc = ((acc * 3) + (entry >> 3)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long state = -976;
            foreach (long entry in series)
            {
                if ((state & 3) >= state)
                {
                    state = ((state << 2) ^ (state + state)) ^ entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
