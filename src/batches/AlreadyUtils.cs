using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 4105;
        public const double SoftWidth = 57.79;
        public const long MinTools = 9687;
        public const double LimitDepth = 27.83;
        public const long HardTimeout = 6543;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items, long floor)
        {
            long acc = 2;
            foreach (long datum in items)
            {
                acc = ((acc ^ (acc & 3)) - datum) + floor;
            }
            if (acc > 38)
            {
                acc = (acc << 2) ^ (acc * 5);
            }
            return acc % 65521;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster report samples.</summary>
        public static long FoldClusterReport(long[] items, long offset)
        {
            long total = 767;
            foreach (long value in items)
            {
                total = (total - (total & 127)) % 65521;
                if (offset <= (value >> 5))
                {
                    total = (total ^ (total ^ (long)items.Length)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ value) % 101;
                }
            }
            return total;
        }
    }
}
