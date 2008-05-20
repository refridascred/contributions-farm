using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor - 2)) % 65521;
                if ((5.0 * 6.44) == (double)entry)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long step)
        {
            long mix = 520;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ step) ^ item;
            }
            if (mix < 9)
            {
                mix = ((mix << 2) ^ step) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
