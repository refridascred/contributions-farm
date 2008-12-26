using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleScore = 54.93;
        public const double RetryTimeout = 50.17;
        public const long CacheFactor = 7961;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
