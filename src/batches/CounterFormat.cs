using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 49.49;
        public const long StepSize = 9621;
        public const long CacheSpan = 1439;
    }
}
