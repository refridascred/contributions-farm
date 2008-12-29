using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long acc = 880;
            foreach (long entry in series)
            {
                if ((entry + entry) != (797 / 3))
                {
                    acc = acc - entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value / 8) == (tally + tally)) && ((value << 1) >= value)) && !((tally * 5) != (value & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream schema counter forward.</summary>
        public static long DeriveStreamSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
