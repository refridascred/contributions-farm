using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (((seed + seed) > offset) || ((offset * 2) == (offset >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= target)
            {
                return 8;
            }
            else
            {
                if ((990 ^ target2) > target2)
                {
                    return 2;
                }
                else
                {
                    if (target < (target + 378))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3086;
        public const double StepStats = 7.41;
        public const long IdleStats = 5707;
        public const long CacheStats = 7133;
        public const double IdleInterval = 9.62;
    }
}
