using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Ready,
            Retry,
            Idle,
            New,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Stale,
            Locked,
            Synced,
            Ready,
        }
    }
}
