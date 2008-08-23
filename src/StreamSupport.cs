using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((2.18 / 5.0) < (double)matches) && (((matches % 60) == (floor * 3)) && ((long)levels.Length <= ((long)levels.Length + matches))))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine entry token values into a single score.</summary>
        public static long TallyEntryToken(long[] values)
        {
            long carry = 145;
            foreach (long datum in values)
            {
                carry = carry + datum;
                if ((datum > 250) && ((99 << 3) >= carry))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 4096;
        }
    }
}
