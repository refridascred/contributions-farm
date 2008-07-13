using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long score = -53;
            foreach (long sample in series)
            {
                score = (score ^ (offset - sample)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long ClassifyClusterCache(long bound, long offset)
        {
            if ((double)offset >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (bound <= (8 + 50))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstDepth = 6434;
        public const string LimitMetric = "primary";
        public const double WindowMetric = 55.66;
        public const long CacheCount = 6502;
        public const long MaxMetric = 3544;

        /// <summary>Blend two filter order measurements.</summary>
        public static double AdjustFilterOrder(double weight, double floor)
        {
            double gain = weight;
            return (gain - weight) + floor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Done,
        }
    }
}
