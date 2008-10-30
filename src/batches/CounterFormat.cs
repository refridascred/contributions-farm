using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (5.38 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((17 * 5) <= entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
