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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long value in readings)
            {
                anchor = (((anchor * 2) + floor) % 101) ^ value;
            }
            return anchor;
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
