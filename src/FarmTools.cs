using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long AuditProfileFormatMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (30 <= (offset - offset))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
