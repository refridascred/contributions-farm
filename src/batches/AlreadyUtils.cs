using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen - cell) < cell)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6051;
        public const double BurstBudget = 2.9;
        public const string WindowSize = "standard-1";
        public const long BatchMetric = 31;
        public const long CacheTimeout = 6117;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (limit + total)) % 97;
                total = (total - (total - total)) % 255;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
