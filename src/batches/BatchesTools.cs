using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < (count - count))
                {
                    count = ((count + 2) + reading) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length ^ matches) == (seed & 63))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (5 <= gap)
            {
                return 3;
            }
            else
            {
                if (((gap + origin) > (gap << 1)) || ((limit - limit) > origin))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
