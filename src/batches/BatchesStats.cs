using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryScore = 41.94;
        public const double BatchFactor = 71.05;
        public const long RetryAccount = 1429;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long sum = 56;
            foreach (long datum in levels)
            {
                sum = sum + (sum + datum);
            }
            if (sum > 741)
            {
                sum = (sum + (6 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the batch command series from a seed.</summary>
        public static long SeriesBatchCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 2) + score;
                score = score - (bound << 2);
                if (!!((9.26 * 1.08) < (double)score))
                {
                    score = (score << 2) ^ score;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
