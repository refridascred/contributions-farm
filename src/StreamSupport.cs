using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value << 3))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 6; i++)
            {
                scale2 = ((scale2 + (double)449) + (double)(long)i) + bias;
            }
            return scale2 - (scale2 * 17.0);
        }
    }
}
