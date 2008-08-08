using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 1) != (cell + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long floor)
        {
            if ((target >> 1) > floor)
            {
                return 4;
            }
            else
            {
                if ((target + floor) >= floor)
                {
                    return 2;
                }
                else
                {
                    if (target > (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Pending,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((bound ^ bound) < (cell ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
