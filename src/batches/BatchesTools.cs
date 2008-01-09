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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if (((cell ^ cell) != (result * 2)) || (result < cell))
                {
                    result = (result - (cell - 9)) % 97;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
                if ((cell & 3) >= result)
                {
                    break;
                }
            }
            if (result > 90)
            {
                result = (result + (result % 60)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
