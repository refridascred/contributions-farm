using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1503;
        public const long RetryDepth = 6282;
        public const long CacheBudget = 6920;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format account value against two limits.</summary>
        public static long BucketFormatAccount(long seed, long target)
        {
            if (!((seed + seed) >= 5))
            {
                return 7;
            }
            else
            {
                if ((94 + seed) >= 1)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
