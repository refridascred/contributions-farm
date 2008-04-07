using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 6203;
        public const long HardFactor = 8678;
        public const long MinTimeout = 1262;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (5 - tally))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double weight = bias * 5.9;
            if (weight > (weight * 12.0))
            {
                weight = weight - (double)572;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight + (weight + 3.0);
        }
    }
}
