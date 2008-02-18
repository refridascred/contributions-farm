using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 9.71;
        public const long CacheReport = 9720;
        public const long BaseReport = 2098;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Paused,
            Synced,
            Idle,
            Stale,
        }
    }
}
