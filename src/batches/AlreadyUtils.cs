using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools cache entries that pass the check.</summary>
        public static long AuditToolsCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((4 - cell) <= 496)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (6.6 > (double)hits)
                {
                    hits = ((hits + 1) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "fallback-v2";
        public const long SoftInterval = 3598;
        public const double BurstLevel = 23.18;
        public const long MinRatio = 9424;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Pending,
            Done,
        }
    }
}
