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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
