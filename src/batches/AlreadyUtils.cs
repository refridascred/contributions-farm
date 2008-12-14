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

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > gain)
            {
                gain2 = gain2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (span + 18.0)) + (double)(long)i;
            }
            return gain2 - (double)20;
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

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long LookupContextChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
