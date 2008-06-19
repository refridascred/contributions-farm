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

        /// <summary>Locate a tools account reading by value.</summary>
        public static long SeekToolsAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
