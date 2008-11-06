using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2109;
        public const long CacheFormat = 8577;
        public const long MinCount = 5697;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
