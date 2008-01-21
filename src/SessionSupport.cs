using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Queued,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long anchor = 33;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ (anchor - reading);
                anchor = ((anchor << 3) ^ (reading >> 4)) % 1000;
            }
            return anchor % 1000;
        }
    }
}
