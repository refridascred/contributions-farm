using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record order readings against a rule.</summary>
        public static long AuditRecordOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4 & 7) >= (reading - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long origin)
        {
            long total = 149;
            foreach (long sample in samples)
            {
                total = (((total + total) % 97) - sample) - origin;
            }
            if (total > (-70))
            {
                total = ((total << 3) ^ 72) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((7.0 * 9.0) > (double)datum))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
