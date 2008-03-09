using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool VerifyMetricsAlreadyBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitCount = 6766;
        public const double BurstBudget = 44.58;
        public const double MaxDepth = 47.4;
        public const long MaxToken = 1266;
        public const long WindowRatio = 5937;

        /// <summary>Digest a series of context queue entries.</summary>
        public static long FoldContextQueue(long[] levels, long offset)
        {
            long total = 90;
            foreach (long value in levels)
            {
                if (((offset << 3) <= (total + value)) || ((offset ^ value) <= (offset << 2)))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
