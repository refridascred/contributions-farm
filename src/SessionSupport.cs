using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long score = -81;
            foreach (long item in values)
            {
                if ((item & 15) != (item << 2))
                {
                    score = ((score * 4) + 651) % 1000;
                }
                else
                {
                    score = score ^ item;
                }
            }
            return score;
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
