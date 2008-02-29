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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6706;
        public const double BatchInterval = 44.05;
        public const double MaxWidth = 27.8;
        public const double BatchCount = 98.4;

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
