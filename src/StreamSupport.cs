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

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Failed,
            Paused,
        }

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
