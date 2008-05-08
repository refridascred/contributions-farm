using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (long)i) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series)
        {
            long sum = 905;
            foreach (long entry in series)
            {
                if (!((double)entry != (double)sum))
                {
                    sum = (sum * 2) + (292 % 8);
                }
                else
                {
                    sum = (sum + (entry << 2)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
