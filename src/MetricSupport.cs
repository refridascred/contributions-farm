using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9085;
        public const long IdleBatches = 3145;
        public const string CacheScore = "strict";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinBudget = 88.02;
        public const long SoftLayout = 3996;
        public const long BaseLayout = 7693;
        public const string WindowBudget = "alpha-v2";
    }
}
