using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (26 > (entry & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
