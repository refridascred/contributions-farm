using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.3 + 10.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(seen <= (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long state = 90;
            foreach (long entry in levels)
            {
                if ((state ^ (-45)) != (state >> 4))
                {
                    state = (state + (4 % 12)) - entry;
                }
            }
            return state;
        }
    }
}
