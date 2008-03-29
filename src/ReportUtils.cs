using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= (6.0 * 4.64)))
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long limit)
        {
            long next = offset ^ limit;
            if (!(next <= (limit + 52)))
            {
                return 0;
            }
            else
            {
                if ((offset + next) > (limit * 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long target)
        {
            if (!(target < (limit << 2)))
            {
                return 4;
            }
            else
            {
                if (limit >= (70 >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((target - limit) != (limit / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
