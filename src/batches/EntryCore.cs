using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if ((mark * 4) <= (mark * 2))
                {
                    mark = ((mark - (mark << 1)) % 255) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 37.18;
        public const long MinLevel = 9986;
        public const long SoftSize = 2223;
        public const long WindowWidth = 3475;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
