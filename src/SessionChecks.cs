using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Draft,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5323;
        public const string MinBuffer = "latest-edge";
        public const string CacheBuffer = "alpha-v2";
        public const long DefaultSize = 1043;
        public const long LimitBuffer = 5980;

        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool CheckTokenQueueLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
