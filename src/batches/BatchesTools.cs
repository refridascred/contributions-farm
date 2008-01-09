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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count & 127) == (bound / 2)) && ((entry & 15) >= (-86)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
