using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0.42 / 9.0) <= (double)seen)
                {
                    seen = ((seen + 2) + datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9.91 * 8.62) <= (double)limit)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
