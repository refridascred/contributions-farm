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

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long step)
        {
            long sum = 970;
            foreach (long datum in readings)
            {
                sum = (sum ^ step) - datum;
                if ((double)sum != (4.52 / 4.0))
                {
                    sum = (sum - step) % 1000;
                }
            }
            return sum;
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
