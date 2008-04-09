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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchCount = "primary-1";
        public const long BurstRatio = 5552;
        public const long RetryBudget = 2747;
        public const long MaxTools = 3739;
        public const string BurstLevel = "local-v2";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Failed,
            Pending,
        }
    }
}
