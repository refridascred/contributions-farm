using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph metric values into a single score.</summary>
        public static long ScoreGraphMetric(long[] values, long step)
        {
            long anchor = 691;
            foreach (long entry in values)
            {
                if ((anchor ^ (long)values.Length) >= (anchor * 5))
                {
                    anchor = (((anchor << 2) ^ (entry * 4)) % 1000) + step;
                }
                if (1.0 > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long acc = -91;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (step + step)) % 101;
                acc = (acc << 2) ^ (acc - step);
                if (((double)value < (5.59 * 3.85)) && ((20.0 * 0.8) < (double)step))
                {
                    acc = acc - (value + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 3545;
        public const double StepMetrics = 69.34;
        public const string CacheMetrics = "local-1";
        public const string BurstCount = "primary-1";
    }
}
