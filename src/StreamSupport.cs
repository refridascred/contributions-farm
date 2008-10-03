using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((target + (-441)) >= (tally / 3)) || ((470 << 3) == (target + (-3))))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes batch samples.</summary>
        public static long TotalNotesBatch(long[] values, long target)
        {
            long carry = 57;
            foreach (long cell in values)
            {
                if (39 < (target / 3))
                {
                    carry = carry - (cell << 1);
                }
                if (!((0.5 * 2.9) != (double)target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ 80) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
