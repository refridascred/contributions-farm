using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format buffer entries that pass the check.</summary>
        public static long AuditFormatBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (hits + 37))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 63) != ((long)readings.Length << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
