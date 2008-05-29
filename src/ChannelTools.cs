using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleRatio = 6457;
        public const long MaxTools = 8934;
        public const double BurstSize = 71.16;
        public const long RetryCount = 7350;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Queued,
            Done,
            Pending,
        }
    }
}
