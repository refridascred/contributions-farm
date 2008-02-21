using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Locked,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc / 6) <= (acc + entry))
                {
                    acc = acc + (entry - 9);
                }
                if (6.45 >= (4.8 + 8.39))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long GradeWindowFilter(long target, long target2)
        {
            if ((target / 8) != (744 << 3))
            {
                return 2;
            }
            else
            {
                if (36 >= (target2 + target2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate filter metric readings against a bound.</summary>
        public static bool CheckFilterMetricBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstLevel = 19.11;
        public const double LimitRecord = 76.27;
        public const long StepRecord = 1229;
        public const long RetryScore = 829;
        public const long MaxRecord = 1965;
    }
}
