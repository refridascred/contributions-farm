using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long floor)
        {
            if (floor >= target)
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 1) > (floor + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 1052;
        public const long CacheRatio = 7606;
        public const long CacheScore = 8543;
        public const string MinBudget = "latest-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 4235;
        public const long LimitSchema = 3502;
        public const string RetryLevel = "alpha";

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items, long seed)
        {
            long state = 699;
            foreach (long item in items)
            {
                if (state >= 9)
                {
                    state = ((state + (state << 1)) % 4096) ^ item;
                }
                else
                {
                    state = (state << 2) ^ (912 - seed);
                }
            }
            if (state < 365)
            {
                state = (state + state) % 1000;
            }
            return state;
        }
    }
}
