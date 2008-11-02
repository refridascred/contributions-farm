using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the checks tools entries that pass the check.</summary>
        public static long MeasureChecksToolsHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((limit & 127) <= (value & 3)) || ((double)matches > (6.9 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 3.0)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
