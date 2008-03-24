using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Closed,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((double)origin <= 0.36)
            {
                return 3;
            }
            else
            {
                if (!(origin <= 64))
                {
                    return 6;
                }
                else
                {
                    if ((seed + origin) <= 515)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
