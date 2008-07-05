using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next window batches value from a seed.</summary>
        public static long DeriveWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i % 3) <= (carry + carry))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a schema record reading by value.</summary>
        public static long LocateSchemaRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count < (bound + count)) || ((count - (long)samples.Length) > count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ entry) == (matches << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
