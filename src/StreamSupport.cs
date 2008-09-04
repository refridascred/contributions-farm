using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1426;
        public const long BaseMetrics = 9817;
        public const long DefaultMetrics = 1482;
        public const string RetryMetrics = "alpha-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 1161;
        public const double SoftRatio = 51.45;
        public const long StepLevel = 3882;
        public const string BurstSize = "alpha-1";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
