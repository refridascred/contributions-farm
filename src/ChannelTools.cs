using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 4563;
        public const double HardSpan = 83.32;
        public const double SoftWidth = 94.54;
        public const long BurstWindow = 3603;
        public const string CacheScore = "legacy";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
