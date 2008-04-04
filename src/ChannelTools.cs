using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 6667;
        public const string RetryOrder = "latest";
        public const string BaseOrder = "latest-v2";
        public const long BurstOrder = 5904;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Draft,
            Pending,
            Stale,
            Active,
        }
    }
}
