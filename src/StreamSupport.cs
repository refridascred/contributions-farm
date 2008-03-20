using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 9809;
        public const string RetrySize = "staging-1";
        public const double RetryChannel = 47.8;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleRatio = 8309;
        public const long BatchSchema = 477;
        public const long BurstSchema = 6323;
        public const long WindowSchema = 5749;
        public const long LimitScore = 8599;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long limit2)
        {
            if (limit2 > (limit2 + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit2 <= 6.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
