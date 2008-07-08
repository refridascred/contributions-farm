using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.6 + 9.3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCount = 4404;
        public const string MinCommits = "primary-edge";
        public const double BaseInterval = 60.93;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 3095;
        public const long MaxLayout = 5299;
        public const long SoftRatio = 7533;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count % 10) >= (floor * 2)) || ((double)count > (2.35 * 17.0))) || (((-530) & 63) < (256 ^ value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long AuditClusterGraphMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleWidth = 6384;
        public const long CacheCounter = 2663;
        public const long WindowDepth = 6462;
        public const string MinCounter = "legacy";
    }
}
