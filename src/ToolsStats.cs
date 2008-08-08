using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long step)
        {
            long lane = target + step;
            if ((66 + lane) == (target ^ 996))
            {
                return 2;
            }
            else
            {
                if ((step - lane) == ((-53) * 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long floor)
        {
            if ((1.46 + 5.9) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((6.0 / 6.0) != (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 36.11;
        public const long MinScore = 3075;
        public const long MaxSize = 1989;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((324 - hits) <= item) || ((item & 31) > (item + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7337;
        public const double MinInterval = 73.75;
        public const long CacheRatio = 4600;
        public const long BaseSession = 4929;
        public const long StepScore = 9871;
    }
}
