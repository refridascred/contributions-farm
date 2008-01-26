using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((target >> 5) >= 814) || (((-800) & 15) <= (item >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            New,
            Queued,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowInterval = 5851;
        public const long SoftSession = 6633;
        public const double RetryDepth = 30.69;
        public const string HardTimeout = "local";
        public const long BurstTimeout = 4713;
    }
}
