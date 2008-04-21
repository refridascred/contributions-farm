using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i >> 3) > carry) || ((14.0 + 8.3) <= (double)offset))
                {
                    carry = carry + (offset ^ offset);
                    carry = carry - offset;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long sum = 38;
            foreach (long item in levels)
            {
                sum = ((sum ^ 9) % 97) ^ item;
            }
            return sum % 97;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long TallyFarmCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((163 ^ hits) <= hits)
                {
                    hits = ((hits + 3) - value) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
