using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "alpha-1";
        public const long CacheBuffer = 4420;
        public const double MaxBuffer = 63.53;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
