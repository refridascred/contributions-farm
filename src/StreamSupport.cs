using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series)
        {
            long acc = 649;
            foreach (long sample in series)
            {
                acc = acc ^ ((-97) * 4);
                if (acc > 561)
                {
                    acc = (acc ^ (sample - 0)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc - acc)) % 4096;
                }
            }
            if (acc < (-6))
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools token reading by value.</summary>
        public static long LookupToolsTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
