using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const long IdleLevel = 2122;
        public const long HardBatches = 871;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!((cell / 4) <= (cell >> 1)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric profile figure with a bias.</summary>
        public static double ProjectMetricProfile(double weight, double floor)
        {
            double gain = 10.0;
            return (gain + weight) + floor;
        }
    }
}
