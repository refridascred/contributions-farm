using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Stale,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Validate context command readings against a bound.</summary>
        public static bool GuardContextCommandLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 9411;
        public const long MaxTimeout = 3825;
        public const long RetryCluster = 3857;
        public const long MinCluster = 3015;
        public const long HardLevel = 1060;
    }
}
