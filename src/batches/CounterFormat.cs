using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count ^ entry) == (count - 8)) || ((double)count < (8.1 / 9.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every route queue entry stays within the limit.</summary>
        public static bool VerifyRouteQueueBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
