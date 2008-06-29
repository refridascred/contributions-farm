using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "stable-edge";
        public const string BurstBudget = "latest";
        public const double IdleBudget = 23.37;
        public const double IdleAccount = 49.74;
        public const long SoftRatio = 1405;

        /// <summary>Count route editor pairs that satisfy a relation.</summary>
        public static long OverlapRouteEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((685 >> 1) == (seed + bound))
            {
                return 8;
            }
            else
            {
                if ((seed + bound2) >= (bound / 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (6.1 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 18;
            foreach (long value in items)
            {
                state = state ^ (1 - value);
                if ((double)281 != (double)value)
                {
                    state = state ^ ((long)items.Length + value);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            return state % 1000;
        }
    }
}
