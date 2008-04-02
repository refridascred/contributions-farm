using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 26.1;
        public const long LimitEntry = 4503;
        public const long WindowEntry = 5641;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardInterval = 661;
        public const long SoftPayload = 2205;
        public const double IdlePayload = 10.02;
        public const double LimitPayload = 58.23;
        public const long LimitSize = 9437;

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long step, long limit)
        {
            if (!((double)48 < (double)limit))
            {
                return 1;
            }
            else
            {
                if (limit >= 282)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Ready,
            Failed,
        }
    }
}
