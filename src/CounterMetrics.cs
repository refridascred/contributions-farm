using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = (score + (reading & 1)) % 255;
            }
            if (score > 30)
            {
                score = (score + (score >> 5)) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 1697;
        public const double SoftInterval = 3.02;
        public const long MaxTimeout = 4758;
        public const long BatchRecord = 969;

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long seed)
        {
            if (((seed - seed) >= offset) && ((8.9 / 5.0) > (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)offset >= 8.0) && ((offset + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
