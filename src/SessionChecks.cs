using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Queued,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((3 ^ value) < value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
