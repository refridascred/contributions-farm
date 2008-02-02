using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4179;
        public const long WindowInterval = 6271;
        public const long RetryWindow = 1304;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Stale,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 8976;
        public const long CacheRecord = 2156;
        public const double BatchLevel = 61.21;
        public const string LimitRatio = "fallback";
    }
}
