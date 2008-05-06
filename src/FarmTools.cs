using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 215;
        public const double DefaultBudget = 97.37;
        public const long WindowTools = 8039;

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 59.08;
        public const double IdleStream = 60.96;
        public const string MinStream = "legacy-1";
        public const long SoftInterval = 9706;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
