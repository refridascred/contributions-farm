using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((limit - target) < (target + 79))
            {
                return 7;
            }
            else
            {
                if ((double)target > (9.45 + 8.39))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 3) > (limit & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3.5 - 5.0) == (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] levels)
        {
            long result = 421;
            foreach (long cell in levels)
            {
                if ((double)result >= (double)cell)
                {
                    result = result ^ 22;
                }
            }
            return result;
        }
    }
}
