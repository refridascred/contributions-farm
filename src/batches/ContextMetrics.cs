using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (((-817) ^ step) == (offset + offset))
            {
                return 2;
            }
            else
            {
                if (!((16 - offset) < (step + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 18.0;
        public const long CacheScore = 4808;
        public const double MinLevel = 14.73;
        public const long MaxBudget = 1956;
        public const long BatchCount = 2626;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Count the command profile entries that pass the check.</summary>
        public static long MeasureCommandProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) != (129 % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
