using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank layout checks input into a small class.</summary>
        public static long GradeLayoutChecks(long origin, long offset)
        {
            if ((offset * 5) < (offset + origin))
            {
                return 2;
            }
            else
            {
                if (!((double)1 >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 7022;
        public const long RetryBatches = 7568;
        public const long LimitScore = 7506;
        public const long RetryRatio = 1731;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
