using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)reading < (1.7 / 7.0)) && (7.0 <= (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric entry samples are out of range.</summary>
        public static long AuditMetricEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((88 + matches) >= 3))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
