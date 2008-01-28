using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 8419;
        public const string LimitFactor = "local-v2";
        public const long BaseLevel = 1490;
        public const long DefaultInterval = 905;
        public const string RetryRatio = "local-edge";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long step)
        {
            long delta = limit + step;
            if (((double)delta > (double)(-134)) && ((double)limit > (8.0 + 8.4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)12)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long seed)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                state = ((state * 3) + (state ^ entry)) - seed;
            }
            if (state > 54)
            {
                state = (state * 5) + (state + state);
            }
            return state % 65521;
        }
    }
}
