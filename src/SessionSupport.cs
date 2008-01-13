using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                long seen = result % 16;
                if ((double)seen != (9.1 * 13.0))
                {
                    break;
                }
                result = ((result + (474 + result)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }
    }
}
