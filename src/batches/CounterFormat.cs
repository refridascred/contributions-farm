using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long carry = 88;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (carry % 2)) % 65521) ^ datum) + limit;
            }
            return carry;
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
