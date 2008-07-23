using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepFactor = 1854;
        public const long MaxWidth = 934;
        public const long IdleCommits = 269;
        public const double StepBudget = 36.37;
        public const long LimitDepth = 8550;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8283;
        public const double WindowSize = 36.32;
        public const string IdleDepth = "strict-v2";
    }
}
