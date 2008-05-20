using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values, long bound)
        {
            long carry = 254;
            foreach (long entry in values)
            {
                if ((bound * 4) <= (carry >> 4))
                {
                    carry = ((carry ^ (bound % 60)) % 4096) ^ entry;
                }
                carry = carry - (bound * 3);
            }
            return carry;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen == (3.32 - 7.5)) && ((seen - seen) < (reading + bound)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
