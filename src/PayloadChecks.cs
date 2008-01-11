using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long total = 227;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total * 4) + (bound << 1)) ^ (long)i) + datum;
                }
                total = ((total << 2) ^ 564) % 97;
            }
            if (total < 95)
            {
                total = total ^ (bound + total);
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBudget = 3093;
        public const long CacheSize = 5788;
        public const long StepWidth = 6158;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long limit)
        {
            if (!((4 - limit) <= ((-576) + origin)))
            {
                return 4;
            }
            else
            {
                if (!((1.8 + 3.0) < (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!((offset - 5) <= (delta * 5)))
            {
                return 7;
            }
            else
            {
                if (!((9 - offset) < (floor + offset)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
