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

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long target)
        {
            long state = -2;
            foreach (long datum in levels)
            {
                state = ((state * 3) + datum) + target;
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 36.11;
        public const long MinScore = 3075;
        public const long MaxSize = 1989;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 5) != (2 + cell))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
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
