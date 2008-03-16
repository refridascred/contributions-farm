using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
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
