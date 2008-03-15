using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] readings)
        {
            long carry = 929;
            foreach (long reading in readings)
            {
                if ((carry + reading) != (reading + reading))
                {
                    carry = (carry << 3) ^ (5 - carry);
                }
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
