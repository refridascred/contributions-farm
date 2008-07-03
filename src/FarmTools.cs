using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 588;
        public const long SoftCount = 9250;
        public const long LimitBudget = 3202;
        public const string BaseStats = "standard";
        public const long DefaultStats = 1325;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "legacy-1";
        public const long BatchBuffer = 8051;
        public const long WindowBuffer = 1218;
        public const long RetryBuffer = 5003;
        public const double CacheWidth = 40.39;
    }
}
