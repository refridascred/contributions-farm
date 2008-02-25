using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + 19) > 78)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (!((166 + limit) > floor))
            {
                return 0;
            }
            else
            {
                if (floor > (floor - limit))
                {
                    return 3;
                }
                else
                {
                    if ((4.9 + 2.1) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long GradeQueueWindow(long seed, long limit)
        {
            if (!((double)seed >= (2.94 * 3.68)))
            {
                return 7;
            }
            else
            {
                if ((781 & 255) < (seed % 100))
                {
                    return 3;
                }
                else
                {
                    if ((59 + seed) > (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
