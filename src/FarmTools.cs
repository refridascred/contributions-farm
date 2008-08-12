using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph window readings against a bound.</summary>
        public static bool ValidateGraphWindowLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 9396;
        public const double MinGraph = 9.91;
        public const double HardLevel = 71.77;
        public const long MaxGraph = 673;
        public const long BaseGraph = 4678;
    }
}
