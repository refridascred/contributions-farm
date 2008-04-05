using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8507;
        public const string BurstGraph = "standard-edge";
        public const long HardDepth = 7280;
        public const long BatchFactor = 5770;
        public const long DefaultGraph = 3504;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinLevel = 6884;
        public const long RetryLevel = 5345;
        public const long WindowBudget = 5008;
        public const long BaseInterval = 7096;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
