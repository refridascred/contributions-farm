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

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 2) + (mark % 7)) ^ item;
                mark = (mark - (mark << 1)) % 1000;
            }
            return mark;
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
