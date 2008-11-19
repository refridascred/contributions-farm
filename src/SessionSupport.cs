using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Closed,
            Dropped,
            New,
        }

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
