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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9886;
        public const long LimitChannel = 6520;
        public const long CacheChannel = 4518;

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
