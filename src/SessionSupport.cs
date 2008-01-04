using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items, long offset)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if ((5.17 + 1.1) == (double)acc)
                {
                    acc = ((acc - (offset / 8)) % 255) ^ reading;
                }
            }
            if (acc > 430)
            {
                acc = acc ^ (offset + acc);
            }
            return acc;
        }

        /// <summary>Roll a report editor counter forward.</summary>
        public static long RollReportEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + sum;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
