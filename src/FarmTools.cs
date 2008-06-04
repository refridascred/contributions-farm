using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits * 4) > (239 + hits)) && (((double)item != (5.03 / 9.0)) || ((hits - (long)values.Length) > hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.27 + 1.6) > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
