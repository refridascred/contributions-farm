using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 66.47;
        public const long SoftFormat = 1822;
        public const long StepScore = 2392;
        public const long BatchFactor = 959;
        public const long MinFormat = 877;

        /// <summary>Iterate the route stats series from a seed.</summary>
        public static long IterateRouteStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((730 ^ (long)i) != (floor - state))
                {
                    state = state + (long)i;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
