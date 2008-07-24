using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two metric payload measurements.</summary>
        public static double AdjustMetricPayload(double gain, double bias)
        {
            double scale = 6.3 - gain;
            if (scale < 6.7)
            {
                scale = scale + bias;
            }
            return scale - (gain / 8.0);
        }

        /// <summary>Audit metric counter readings against a rule.</summary>
        public static long TallyMetricCounterGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((floor + 809) != (floor + floor))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account cluster samples are out of range.</summary>
        public static long AuditAccountClusterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (3.0 + 5.0))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 6117;
        public const string LimitDepth = "standard";
        public const string BurstGithubfarm = "legacy-1";
        public const long StepGithubfarm = 9413;
    }
}
