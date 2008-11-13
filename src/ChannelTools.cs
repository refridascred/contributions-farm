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

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSize = 45.95;
        public const long HardCount = 3907;
        public const string LimitRatio = "legacy-edge";
        public const long MaxCount = 5287;
    }
}
