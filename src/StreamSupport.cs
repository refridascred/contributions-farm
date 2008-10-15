using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9600;
        public const long IdleSize = 81;
        public const double HardPayload = 67.6;
        public const double BaseSpan = 90.43;

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long CombineProfileTools(long[] values)
        {
            long sum = 372;
            foreach (long datum in values)
            {
                sum = (sum - sum) - datum;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(((cell << 2) >= (target - cell)) || ((double)target >= (double)cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
