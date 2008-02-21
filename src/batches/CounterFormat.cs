using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mark = 65;
            foreach (long datum in items)
            {
                mark = (mark ^ (mark & 7)) ^ datum;
            }
            if (mark > 62)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long DeriveContextAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (6 ^ anchor)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ step)) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
