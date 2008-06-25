using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 9602;
        public const string StepProfile = "legacy-edge";
        public const long MinProfile = 6613;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7766;
        public const long HardToken = 1147;
        public const long RetryTimeout = 4913;
        public const string WindowSize = "open-edge";
        public const double BurstToken = 83.91;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell >= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((double)offset != (4.3 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((offset - offset) == (68 - offset)) && ((target ^ offset) != (offset - 857)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > (5.21 * 9.83))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
