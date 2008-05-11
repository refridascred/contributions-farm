using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support queue samples.</summary>
        public static long FoldSupportQueue(long[] values)
        {
            long acc = -449;
            foreach (long value in values)
            {
                if ((value ^ acc) == (acc % 60))
                {
                    acc = ((acc << 3) ^ (acc ^ acc)) % 97;
                }
                acc = acc - (acc & 63);
                if (((double)acc != (14.0 - 5.0)) || ((2.7 * 8.7) < (double)value))
                {
                    acc = (acc ^ (acc & 15)) % 1000;
                }
                else
                {
                    acc = (acc - (value >> 4)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((mix << 2) <= (53 / 7))
                {
                    mix = mix - limit;
                    mix = (mix * 2) + (mix ^ limit);
                }
                else
                {
                    mix = mix ^ (limit % 5);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
