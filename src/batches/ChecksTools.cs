using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long target)
        {
            long next = floor ^ target;
            if (((9 - floor) < (next << 2)) || ((next << 2) > (floor % 97)))
            {
                return 3;
            }
            else
            {
                if (882 < (target & 15))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBudget = "standard";
        public const string BaseBatches = "local-1";
        public const double MaxBatches = 98.14;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 56.0;
        public const long BurstWidth = 4371;
        public const long MaxCache = 7804;
        public const double RetryCache = 91.21;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Ready,
            Active,
        }
    }
}
