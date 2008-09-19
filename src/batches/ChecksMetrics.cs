using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Idle,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-57) - count) > (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long bound2)
        {
            if ((bound - bound) >= bound)
            {
                return 0;
            }
            else
            {
                if (((bound2 & 31) == (bound2 + 622)) || ((bound2 - bound2) != (bound2 & 63)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Dropped,
            Ready,
            Failed,
            New,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Done,
            Draft,
            Active,
        }
    }
}
