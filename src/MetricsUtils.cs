using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long anchor = 410;
            foreach (long cell in series)
            {
                anchor = (anchor - bound) ^ cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor - (bound / 9)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitRatio = 7155;
        public const long SoftAlready = 4179;
        public const long StepBudget = 9931;
        public const long DefaultRatio = 5708;
    }
}
