using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a checks filter reading by value.</summary>
        public static long LookupChecksFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 286;
            foreach (long sample in data)
            {
                state = (state << 3) ^ (78 % 64);
                if (((state & 15) <= sample) || ((double)state <= (7.9 / 5.0)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
