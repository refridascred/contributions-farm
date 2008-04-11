using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many support format samples are out of range.</summary>
        public static long TallySupportFormatMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)offset == (double)matches)
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((1.0 * 6.75) == (double)seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >= (item / 5)) && ((double)matches > 1.0)) && ((item > (3 / 7)) && ((double)item > (6.08 + 2.13))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
