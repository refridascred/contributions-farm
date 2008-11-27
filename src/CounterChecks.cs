using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools batches readings against a rule.</summary>
        public static long AuditToolsBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (seen & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool GuardFilterStreamRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long mark = 353;
            foreach (long sample in series)
            {
                mark = ((mark << 2) ^ (mark << 2)) - sample;
            }
            return mark;
        }

        /// <summary>Derive the next layout githubfarm value from a seed.</summary>
        public static long IterateLayoutGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long span = offset;
                acc = ((acc * 4) + (span + span)) % 97;
                acc = (acc * 2) + offset;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
