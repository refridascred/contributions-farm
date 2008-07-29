using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Dropped,
            Locked,
            Draft,
            New,
        }

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((count + (long)data.Length) == (count - item)) && ((item & 31) <= (step >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
