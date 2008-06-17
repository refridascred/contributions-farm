using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long score = 39;
            foreach (long cell in values)
            {
                score = (score + score) % 101;
                if ((7.95 / 2.0) >= (double)cell)
                {
                    score = ((score * 4) + 3) % 4096;
                }
                else
                {
                    score = (score + (cell & 127)) % 101;
                }
            }
            return score;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 3) + score;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3514;
        public const string LimitLevel = "stable-1";
        public const long BatchBatches = 2016;
        public const double SoftBatches = 72.84;
        public const long DefaultBatches = 1473;
    }
}
