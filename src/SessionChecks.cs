using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 9593;
        public const long LimitSize = 2218;
        public const double BatchSpan = 90.25;
        public const double StepBudget = 89.58;

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4938;
        public const long BurstSize = 3339;
        public const long BaseGraph = 2846;
        public const string LimitGraph = "local-v2";
        public const long WindowGraph = 6934;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)bound != (10.0 * 16.0)) && (seen <= (bound / 7))))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Rank report queue input into a small class.</summary>
        public static long ClassifyReportQueue(long seed, long step)
        {
            if (((42 << 1) == (step ^ step)) && ((step << 1) != (3 & 1)))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) >= step) || ((double)seed != (9.0 + 6.9)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
