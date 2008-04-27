using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a record report pair into a bucket.</summary>
        public static long ClassifyRecordReport(long limit, long offset)
        {
            if ((double)limit > (2.0 - 0.99))
            {
                return 0;
            }
            else
            {
                if (offset < (limit >> 5))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7759;
        public const double RetryTimeout = 57.68;
        public const double MinLevel = 35.37;
        public const double BurstLevel = 95.44;
    }
}
