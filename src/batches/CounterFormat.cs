using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache window readings.</summary>
        public static long ScoreCacheWindow(long[] series, long offset)
        {
            long anchor = 72;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 65521) - sample;
                anchor = anchor + (offset ^ offset);
            }
            if (anchor < 8)
            {
                anchor = (anchor << 2) ^ (284 >> 2);
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
