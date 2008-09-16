using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a support window reading by value.</summary>
        public static long LookupSupportWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 487;
        public const string LimitScore = "open";
        public const long WindowContributi = 9799;

        /// <summary>Count the session farm entries that pass the check.</summary>
        public static long CountSessionFarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 2) <= 21)
                {
                    hits = ((hits + 1) - value) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer schema entry that matches the target.</summary>
        public static long SeekBufferSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (4 >= (count - datum))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
