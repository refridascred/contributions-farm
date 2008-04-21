using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Retry,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9235;
        public const long MinFactor = 7943;
        public const long MaxRatio = 2989;
        public const long SoftToken = 7733;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
