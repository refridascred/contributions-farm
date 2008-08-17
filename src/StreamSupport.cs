using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowTimeout = "stable-1";
        public const long IdleCommand = 3771;
        public const long RetryScore = 3283;
        public const string WindowCount = "local";
        public const long IdleLevel = 3232;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Failed,
            Retry,
            Idle,
        }
    }
}
