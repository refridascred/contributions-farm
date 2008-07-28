using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long seed, long limit)
        {
            if ((limit << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((748 >> 4) == (97 ^ seed))
                {
                    return 4;
                }
                else
                {
                    if (3 < (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics filter entries.</summary>
        public static long TotalMetricsFilter(long[] data)
        {
            long carry = 16;
            foreach (long value in data)
            {
                if ((value < 3) && ((double)carry < (1.83 * 1.0)))
                {
                    carry = (carry - value) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowSize = "stable-v2";
        public const string RetryRatio = "latest-edge";
        public const long DefaultInterval = 8341;
    }
}
