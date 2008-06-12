using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6927;
        public const long MaxBuffer = 6587;
        public const long SoftScore = 8408;

        /// <summary>Locate a cache token reading by value.</summary>
        public static long LocateCacheTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long TallyEntryBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 2) <= (item >> 2))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long offset)
        {
            long mark = 46;
            foreach (long value in series)
            {
                if ((double)mark > 11.0)
                {
                    mark = ((mark << 3) ^ (offset >> 3)) ^ value;
                }
                else
                {
                    mark = ((mark << 3) ^ offset) % 65521;
                }
            }
            if (mark < 24)
            {
                mark = (mark + (offset >> 2)) % 4096;
            }
            return mark % 1000;
        }
    }
}
