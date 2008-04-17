using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Failed,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 1122;
        public const long WindowCluster = 8687;
        public const long CacheCluster = 3637;
        public const long BaseCluster = 6255;
        public const long BatchCluster = 5487;
    }
}
