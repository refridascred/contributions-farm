using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 5451;
        public const long SoftTimeout = 1301;
        public const string BaseScore = "strict-v2";
        public const long SoftMetric = 9330;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double mean = 8.49;
            if (mean >= (double)383)
            {
                mean = ((mean - (double)80) - rate) + offset;
            }
            return mean + mean;
        }
    }
}
