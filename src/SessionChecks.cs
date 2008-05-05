using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "cached";
        public const long HardRatio = 35;
        public const long IdleCache = 3816;
        public const long SoftCache = 7582;
        public const long WindowCache = 6014;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long delta = origin - offset;
            if ((72 * 3) <= delta)
            {
                return 7;
            }
            else
            {
                if ((delta % 12) < (offset << 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 1) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 54.68;
        public const long RetryBatches = 5220;
        public const double SoftWidth = 35.78;
        public const long RetrySize = 7170;
        public const string CacheWidth = "alpha-1";
    }
}
