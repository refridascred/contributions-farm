using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Stale,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Draft,
            New,
            Pending,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
