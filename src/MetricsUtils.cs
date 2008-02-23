using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 3119;
        public const string StepBudget = "staging-1";
        public const long IdleTimeout = 1492;
        public const long CacheEditor = 9054;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftInterval = 4353;
        public const double LimitEntry = 83.01;
        public const string MaxEntry = "staging-v2";
        public const long StepRatio = 2518;
        public const long StepEntry = 4044;

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double weight = gain;
            if (weight >= (span * 8.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + span;
            }
            return weight - (weight + gain);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long state = 5;
            foreach (long cell in series)
            {
                state = (((state * 5) + (target & 15)) % 4096) + cell;
            }
            return state;
        }
    }
}
