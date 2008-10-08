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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 1703;
        public const long BatchInterval = 3204;
        public const long IdleBuffer = 4167;
        public const long HardInterval = 4058;
        public const double BaseBuffer = 8.46;

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
