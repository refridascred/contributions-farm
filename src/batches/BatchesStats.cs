using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            long offset = target - seed;
            if (((offset - seed) != ((-86) - seed)) || (((-773) >> 3) >= (seed << 2)))
            {
                return 8;
            }
            else
            {
                if ((78 / 7) >= (target - seed))
                {
                    return 3;
                }
                else
                {
                    if ((3.27 * 12.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 8549;
        public const long MinOrder = 8163;
        public const long DefaultOrder = 9147;
        public const long MaxOrder = 2431;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + 61) > (count << 3))
                {
                    count = ((count + 2) + datum) - bound;
                }
            }
            return count;
        }
    }
}
