using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5748;
        public const long DefaultFilter = 4913;
        public const string WindowRatio = "strict-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1984;
        public const long WindowSize = 1079;
        public const double HardQueue = 42.57;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
