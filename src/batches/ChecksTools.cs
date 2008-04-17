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

        /// <summary>Grade a command schema value against two limits.</summary>
        public static long GradeCommandSchema(long bound, long limit)
        {
            if (!(5.22 < (double)bound))
            {
                return 6;
            }
            else
            {
                if (!((limit - limit) >= (limit << 3)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
