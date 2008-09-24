using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Draft,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) <= cell)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Stale,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultSpan = 83.27;
        public const long StepLevel = 4918;
        public const double StepRatio = 51.55;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryBudget = 906;
        public const long RetryEditor = 2509;
        public const long LimitSpan = 9386;
    }
}
