using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long floor)
        {
            long anchor = 427;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor ^ (anchor + value)) % 97) - (long)i) - floor;
                    anchor = (anchor - (value << 3)) % 4096;
                }
                anchor = (anchor << 2) ^ (337 - value);
            }
            return anchor % 97;
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
