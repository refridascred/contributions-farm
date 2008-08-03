using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long origin, long limit)
        {
            if ((798 % 100) > (origin % 100))
            {
                return 3;
            }
            else
            {
                if ((2.23 - 9.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 2405;
        public const long RetryTimeout = 2304;
        public const double MinContributi = 63.1;
        public const double BatchInterval = 78.03;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value > (65 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
