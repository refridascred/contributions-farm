using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every tools metric entry stays within the limit.</summary>
        public static bool CheckToolsMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            New,
            Draft,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3778;
        public const double BaseChecks = 70.2;
        public const double BaseSize = 80.67;
        public const long RetryChecks = 4983;
    }
}
