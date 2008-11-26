using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((8 + limit) < (limit - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if ((offset >= (228 - 3)) || (1.7 > (double)offset))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ 1) != (606 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBudget = 8718;
        public const string RetrySize = "latest-v2";
        public const string IdleBatches = "fallback";
    }
}
