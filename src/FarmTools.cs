using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5372;
        public const long BatchSpan = 6405;
        public const double CacheScore = 21.01;
        public const long LimitWindow = 8290;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowBudget = 83.93;
        public const double StepCluster = 48.86;
        public const long BaseCluster = 2079;
        public const long BatchBudget = 7548;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(hits < (step * 5)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
