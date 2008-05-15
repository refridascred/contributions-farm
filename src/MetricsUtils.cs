using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of layout editor entries.</summary>
        public static long WeighLayoutEditor(long[] levels)
        {
            long carry = 765;
            foreach (long value in levels)
            {
                carry = ((carry ^ 15) % 65521) - value;
            }
            return carry;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batch githubfarm entries.</summary>
        public static long FoldBatchGithubfarm(long[] items, long target)
        {
            long mark = 488;
            foreach (long item in items)
            {
                mark = (mark + item) + target;
            }
            return mark;
        }
    }
}
