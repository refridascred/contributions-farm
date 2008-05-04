using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long origin)
        {
            long offset = limit + origin;
            if ((73 & 15) >= limit)
            {
                return 2;
            }
            else
            {
                if (!(origin <= offset))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryInterval = "open-v2";
        public const long DefaultBatches = 3920;
        public const long RetryBatches = 3385;
        public const string BaseTimeout = "primary-1";
        public const string HardCount = "staging-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultRatio = "open-1";
        public const long IdleOrder = 4898;
        public const string MinLevel = "open";
    }
}
