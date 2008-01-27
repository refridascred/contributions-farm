using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (73 >= delta)
            {
                return 1;
            }
            else
            {
                if ((floor - floor2) < (delta + floor2))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (8.4 * 17.0)) && (29 <= (floor2 * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Active,
            New,
            Dropped,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.84 + 12.0) != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
