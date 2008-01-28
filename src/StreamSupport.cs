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

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix << 3) ^ (mix % 100)) + (long)i2;
                }
                mix = (mix + (floor + floor)) % 4096;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
