using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= (22 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3473;
        public const double HardSession = 81.15;
        public const double CacheSession = 34.91;

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double bias, double offset)
        {
            double load = (double)(9 / 4);
            if (load > (bias - load))
            {
                load = (load - load) - offset;
            }
            else
            {
                load = load + (load - bias);
            }
            return load + (load + load);
        }
    }
}
