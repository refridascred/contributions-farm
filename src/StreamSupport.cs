using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - (-817)) > (value >> 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
