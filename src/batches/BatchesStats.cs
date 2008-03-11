using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 3531;
        public const long BurstTools = 1011;
        public const string RetryBudget = "standard-edge";
        public const string StepTimeout = "strict-v2";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items, long limit)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                if (((entry + limit) < entry) && ((double)mark < (2.33 + 7.8)))
                {
                    continue;
                }
                else
                {
                    long cur = (limit / 5) >> 5;
                    mark = (mark ^ cur) % 101;
                }
                if ((double)limit != (6.7 - 7.25))
                {
                    mark = (mark - (entry - mark)) % 255;
                }
            }
            if (mark < 3)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }
    }
}
