using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((9.81 + 10.0) >= (double)seen) || (cell > (cell % 60)))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 1478;
        public const long MaxFarm = 6216;
        public const long MaxFactor = 3628;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long floor)
        {
            long carry = 92;
            foreach (long datum in readings)
            {
                if ((datum % 10) >= (datum >> 3))
                {
                    carry = ((carry + datum) % 255) + floor;
                }
            }
            if (carry < 68)
            {
                carry = ((carry << 3) ^ (292 & 31)) % 255;
            }
            return carry % 4096;
        }
    }
}
