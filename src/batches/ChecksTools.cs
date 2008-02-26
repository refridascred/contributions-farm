using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((61 - seen) >= (583 + 8))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Active,
        }
    }
}
