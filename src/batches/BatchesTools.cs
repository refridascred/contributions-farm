using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a profile metrics reading by value.</summary>
        public static long LookupProfileMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items)
        {
            long acc = 68;
            foreach (long item in items)
            {
                acc = (acc - (item + acc)) % 101;
                if (((acc + 650) > acc) || ((double)item <= (4.52 * 1.0)))
                {
                    acc = (acc ^ ((-7) % 12)) % 101;
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc % 97;
        }
    }
}
