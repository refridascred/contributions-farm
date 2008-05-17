using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheDepth = 1.51;
        public const double StepCache = 93.09;
        public const long MinBudget = 6921;
        public const double IdleWidth = 21.39;
        public const long SoftFactor = 4206;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Synced,
            Stale,
            Active,
            Locked,
        }
    }
}
