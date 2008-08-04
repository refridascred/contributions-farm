using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5880;
        public const long BatchTimeout = 5692;
        public const long MaxBudget = 6870;
        public const double LimitContext = 2.42;

        /// <summary>Find the first tools already entry that matches the target.</summary>
        public static long LocateToolsAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "cached-edge";
        public const long BaseBatch = 2382;
        public const string RetryBatch = "strict-1";
    }
}
