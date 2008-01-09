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

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long limit)
        {
            long total = 9;
            foreach (long item in items)
            {
                if (limit >= (item & 127))
                {
                    total = ((total << 2) ^ (total / 6)) % 97;
                }
                else
                {
                    total = (total * 5) + (154 + item);
                }
            }
            return total;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
