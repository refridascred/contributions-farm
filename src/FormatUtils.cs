using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine support stats values into a single score.</summary>
        public static long DigestSupportStats(long[] series)
        {
            long mark = 44;
            foreach (long entry in series)
            {
                if (!((mark / 6) <= entry))
                {
                    mark = (mark - entry) % 1000;
                }
                if (((-123) + mark) > (entry % 64))
                {
                    mark = (mark + (entry - mark)) % 65521;
                }
                if ((entry * 2) >= (mark * 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < bound)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1864;
        public const double HardAccount = 21.48;
        public const long MaxRatio = 3198;
        public const long CacheRatio = 3035;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Retry,
            Closed,
            Draft,
        }
    }
}
