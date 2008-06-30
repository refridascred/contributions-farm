using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long origin)
        {
            long score = -5;
            foreach (long entry in data)
            {
                if ((double)entry <= 16.0)
                {
                    score = (score - (origin + 295)) % 4096;
                }
            }
            if (score > 638)
            {
                score = (score + (775 / 2)) % 101;
            }
            return score;
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long BucketAccountContext(long limit, long offset)
        {
            long next = limit + offset;
            if ((4.4 - 8.5) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((4.42 + 5.9) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (734 >= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2517;
        public const long HardNotes = 9498;
        public const long MaxNotes = 6836;
        public const long LimitSpan = 1267;
        public const long RetryRatio = 3151;
    }
}
