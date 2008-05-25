using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                mark = ((mark - ((long)readings.Length + mark)) ^ datum) + seed;
            }
            if (mark > 34)
            {
                mark = ((mark * 4) + (77 ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstTimeout = 51.02;
        public const long RetryAlready = 5473;
        public const long SoftAlready = 6168;
        public const double BaseWidth = 91.87;

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long TallyNotesEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample > matches)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Dropped,
            Done,
            New,
        }
    }
}
