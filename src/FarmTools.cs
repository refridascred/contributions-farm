using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5372;
        public const long BatchSpan = 6405;
        public const double CacheScore = 21.01;
        public const long LimitWindow = 8290;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowBudget = 83.93;
        public const double StepCluster = 48.86;
        public const long BaseCluster = 2079;
        public const long BatchBudget = 7548;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long limit)
        {
            long state = 380;
            foreach (long reading in levels)
            {
                state = (state - limit) % 1000;
                state = (state * 4) + reading;
            }
            return state;
        }
    }
}
