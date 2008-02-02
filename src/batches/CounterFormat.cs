using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long FindContextFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((-121) & 3) != (sample - sample)) && !((5.23 - 7.4) < (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long TallyCounterMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
