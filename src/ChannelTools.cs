using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultTimeout = 49.27;
        public const long CachePayload = 9424;
        public const long MinPayload = 9949;
    }
}
