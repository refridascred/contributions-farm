using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3277;
        public const long WindowSupport = 8307;
        public const long BaseBudget = 9736;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool GuardContributiSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
