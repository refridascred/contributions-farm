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

        /// <summary>Roll a command cluster counter forward.</summary>
        public static long RollCommandCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)seed != (2.56 - 5.9)) || ((total << 2) > 194))
                {
                    total = (total * 5) + (total + seed);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
