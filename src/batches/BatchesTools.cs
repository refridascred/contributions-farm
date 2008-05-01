using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Failed,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }
    }
}
