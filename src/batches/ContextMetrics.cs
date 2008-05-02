using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long origin, long origin2)
        {
            if (199 <= origin)
            {
                return 1;
            }
            else
            {
                if (((origin2 + origin) < (7 >> 4)) && (3.23 >= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (origin < (origin >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((20 & 1) < seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Done,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long edge = floor - limit;
            if (!((9 - edge) >= limit))
            {
                return 8;
            }
            else
            {
                if (floor < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
