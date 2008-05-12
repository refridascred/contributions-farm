using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Queued,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Done,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long mark = 80;
            foreach (long item in levels)
            {
                if ((floor + item) == (floor / 3))
                {
                    mark = ((mark * 5) + (floor ^ floor)) % 97;
                }
                else
                {
                    mark = (mark ^ (item >> 4)) % 101;
                }
            }
            return mark;
        }
    }
}
