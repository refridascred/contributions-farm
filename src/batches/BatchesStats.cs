using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "open-v2";
        public const long MaxReport = 2379;
        public const double IdleReport = 61.82;
        public const long BatchReport = 8295;

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSpan = 9858;
        public const double StepSpan = 68.42;
        public const long DefaultChecks = 4530;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long floor)
        {
            long result = -7;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (result % 2)) + entry) - floor;
            }
            return result;
        }
    }
}
