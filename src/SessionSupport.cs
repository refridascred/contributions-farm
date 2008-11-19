using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 51.79;
        public const double BurstSpan = 36.8;
        public const string DefaultAccount = "local-v2";
        public const long BatchAccount = 2517;

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryRatio = 45.63;
        public const long BurstEntry = 7498;
        public const double MinEntry = 81.38;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long limit)
        {
            long slot = target - limit;
            if ((slot & 63) >= (limit ^ 5))
            {
                return 7;
            }
            else
            {
                if (((2.5 * 7.6) <= (double)slot) && ((double)limit <= (3.2 + 3.5)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
