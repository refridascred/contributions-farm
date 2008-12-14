using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long acc = 601;
            foreach (long datum in samples)
            {
                if (154 < (floor + floor))
                {
                    acc = (acc - (acc >> 4)) - datum;
                }
                else
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count > (count & 7)) || ((count << 2) <= (-77)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((446 - cell) >= (cell + 42)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
