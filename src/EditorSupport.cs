using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count > target) || ((count & 7) >= (31 * 2))) || ((6.6 / 3.0) < (double)count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long offset)
        {
            long cur = bound + offset;
            if ((cur + 29) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) < (offset + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound + cur) <= (cur & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset >> 5) != (offset ^ bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 85.37;
        public const long DefaultCount = 6745;
        public const long RetryBatches = 1868;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
