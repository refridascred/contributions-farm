using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report token values into a single score.</summary>
        public static long WeighReportToken(long[] values)
        {
            long acc = 78;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item * 4);
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long anchor = 179;
            foreach (long reading in items)
            {
                if ((reading ^ 3) >= (reading & 3))
                {
                    anchor = (anchor + (anchor + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + 4) % 101;
                }
                if ((double)reading <= (1.0 - 18.0))
                {
                    anchor = (anchor << 3) ^ floor;
                }
                else
                {
                    anchor = (anchor ^ (reading << 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long CombineBatchesProfile(long[] items)
        {
            long carry = 0;
            foreach (long item in items)
            {
                carry = (carry ^ (long)items.Length) % 97;
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - (item << 1)) % 1000;
                    carry = (carry * 5) + (long)i;
                }
                if ((carry > item) && (372 <= (item << 2)))
                {
                    carry = (carry ^ (carry >> 2)) % 255;
                }
            }
            if (carry < 19)
            {
                carry = (carry * 2) + (9 + carry);
            }
            return carry;
        }
    }
}
