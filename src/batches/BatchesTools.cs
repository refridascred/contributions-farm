using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 4.6;
        public const long WindowSize = 3229;
        public const double MaxStream = 34.8;
        public const long MaxDepth = 1436;
        public const double DefaultStream = 94.96;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 81.25;
        public const double DefaultSize = 23.2;
        public const long SoftLevel = 8306;
        public const long DefaultBudget = 9060;
        public const long LimitMetrics = 7334;
    }
}
