using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Failed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long IterateWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ limit;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
