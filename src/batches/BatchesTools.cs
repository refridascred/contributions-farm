using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 33) >= ((long)series.Length + 807))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitInterval = 69.26;
        public const long StepWidth = 1645;
        public const long BatchFactor = 8329;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 6945;
        public const long CacheLevel = 3115;
        public const double WindowLevel = 51.37;
        public const string LimitGraph = "standard-edge";
    }
}
