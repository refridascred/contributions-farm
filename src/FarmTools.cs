using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 4246;
        public const long RetryChannel = 608;
        public const long IdleBudget = 2605;
        public const long RetrySize = 3858;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
