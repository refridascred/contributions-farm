using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long step)
        {
            if (((limit / 6) > (47 << 3)) && ((5 + step) > (step + step)))
            {
                return 2;
            }
            else
            {
                if ((step + limit) != (limit / 5))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Dropped,
            Active,
            Closed,
            Stale,
        }
    }
}
