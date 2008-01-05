using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data, long origin)
        {
            long carry = 620;
            foreach (long item in data)
            {
                if (item >= (origin & 63))
                {
                    carry = (carry + (carry + item)) % 65521;
                }
            }
            if (carry > 535)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
