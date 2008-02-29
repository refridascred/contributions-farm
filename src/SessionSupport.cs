using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long CountMetricsSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < (3 ^ 69))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value - value) <= (value << 2))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally + tally) <= datum) && ((tally & 255) > (tally % 100)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
