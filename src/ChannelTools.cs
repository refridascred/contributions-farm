using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4011;
        public const long BurstTimeout = 1439;
        public const string IdleDepth = "standard-v2";

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool GuardFilterFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 8242;
        public const long RetryBatch = 4220;
        public const long DefaultInterval = 5356;
        public const long BurstBatch = 223;
        public const long WindowBatch = 1299;
    }
}
