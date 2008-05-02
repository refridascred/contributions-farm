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

        /// <summary>Accumulate notes cache samples.</summary>
        public static long WeighNotesCache(long[] samples)
        {
            long mark = 765;
            foreach (long datum in samples)
            {
                if ((double)datum < (9.0 + 7.0))
                {
                    mark = mark ^ (mark * 5);
                }
            }
            return mark;
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

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long origin)
        {
            if ((seed % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((origin << 3) == (seed - origin))
                {
                    return 5;
                }
                else
                {
                    if (!((8.4 * 3.0) > (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
