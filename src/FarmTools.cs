using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long bound)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = ((mix * 5) + (bound / 5)) % 97;
                mix = (mix - (cell << 3)) % 97;
                if (!((double)mix <= 0.8))
                {
                    mix = (mix ^ (mix - bound)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ bound;
                }
            }
            if (mix < 872)
            {
                mix = ((mix * 2) + (bound * 5)) % 255;
            }
            return mix;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long acc = 72;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ (sample & 31);
            }
            return acc;
        }
    }
}
