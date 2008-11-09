using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long floor)
        {
            long anchor = 40;
            foreach (long sample in readings)
            {
                if ((25 - sample) <= 6)
                {
                    anchor = (anchor + (anchor * 5)) % 4096;
                    anchor = ((anchor * 5) + (sample - floor)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + (462 + floor)) % 101;
                }
                if (!((floor - anchor) <= (floor - floor)))
                {
                    anchor = (anchor * 3) + 3;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) != (6 + (long)samples.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
