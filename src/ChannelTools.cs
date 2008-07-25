using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((hits / 7) <= hits) && (entry >= (entry % 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits & 3) > hits)
                {
                    hits = ((hits + 2) + value) - floor;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long SeekContextChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
