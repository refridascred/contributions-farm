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

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long AuditRecordCacheGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)step < (double)matches) && (((4.0 + 9.65) >= (double)matches) && ((item << 1) <= (item >> 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
