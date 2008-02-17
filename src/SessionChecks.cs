using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((limit >> 2) < (sample - limit))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
