using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (6.0 * 18.0))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4 + cell) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 10) != (tally % 24))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
