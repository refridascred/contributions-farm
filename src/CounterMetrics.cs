using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state - (long)i) % 4096;
                state = state - (floor << 3);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long offset = seed + origin;
            if (origin < (7 % 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8518;
        public const long MinSchema = 8830;
        public const long CacheSchema = 908;
        public const long BurstSchema = 9642;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
