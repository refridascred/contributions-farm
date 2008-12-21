using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Done,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseCount = "alpha-v2";
        public const long RetryAlready = 2052;
        public const long LimitAlready = 4427;
        public const long BurstLevel = 9882;
        public const string BatchLevel = "standard-edge";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((6.3 * 7.56) == (double)cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
