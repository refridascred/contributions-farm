using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            if ((double)offset < (10.0 * 0.7))
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (20.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 ^ 293) > (offset2 - offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 2) > (hits & 63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2342;
        public const long IdleTools = 1245;
        public const long BaseTools = 5066;
        public const long RetryInterval = 4410;
    }
}
