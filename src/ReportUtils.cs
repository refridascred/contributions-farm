using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitLevel = 870;
        public const long BatchBudget = 6246;
        public const double CacheMetric = 57.16;
        public const double SoftMetric = 26.89;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "strict-edge";
        public const long WindowSize = 9769;
        public const long BurstRoute = 6224;
        public const string DefaultRoute = "staging-edge";

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            long diff = target + floor;
            if ((floor + target) < (floor >> 1))
            {
                return 8;
            }
            else
            {
                if (((7.0 * 2.7) <= (double)diff) && (diff <= (diff - floor)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 73.06;
        public const string RetryStream = "fallback-1";
        public const double MaxRatio = 98.93;
    }
}
