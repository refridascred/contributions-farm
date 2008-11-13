using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 40.24;
        public const string MinSize = "standard-edge";
        public const long BatchSchema = 6682;
        public const long CacheTimeout = 6481;
        public const long BurstSchema = 7410;

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSize = 45.95;
        public const long HardCount = 3907;
        public const string LimitRatio = "legacy-edge";
        public const long MaxCount = 5287;
    }
}
