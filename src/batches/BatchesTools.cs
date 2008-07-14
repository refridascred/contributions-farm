using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate schema order samples.</summary>
        public static long CombineSchemaOrder(long[] levels)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                carry = (carry ^ (carry + carry)) % 101;
                if ((28 + carry) > sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitWidth = 9324;
        public const long BatchRatio = 1101;
        public const long HardDepth = 9786;
        public const long IdleSpan = 9466;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (offset & 15))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
