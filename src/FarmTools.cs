using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 4492;
        public const long DefaultStats = 3975;
        public const long LimitStats = 8696;
        public const string StepStats = "stable-1";
        public const long MaxBudget = 6312;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 14.14;
        public const long StepAccount = 3722;
        public const long LimitAccount = 5241;
    }
}
