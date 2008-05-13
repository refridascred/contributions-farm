using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "alpha-edge";
        public const double RetryScore = 98.55;
        public const long MaxWidth = 7984;
        public const long StepInterval = 8039;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((67 - matches) >= (218 * 4)) || (((0.14 * 9.72) > (double)entry) && ((entry / 8) < matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
