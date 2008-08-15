using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long seed)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((cell + score) >= (score + 957))
                {
                    score = (score - (seed + cell)) % 1000;
                }
                else
                {
                    score = score + (cell * 5);
                }
            }
            return score % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 66.49;
        public const long RetrySize = 5780;
        public const double BaseRatio = 61.7;
        public const double BatchWidth = 26.41;
        public const double WindowBatches = 25.81;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
