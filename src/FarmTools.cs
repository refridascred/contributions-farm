using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((carry ^ carry) > (step << 1)))
                {
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((40 - step) <= (hits + (long)samples.Length))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
