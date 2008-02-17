using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items)
        {
            long sum = 337;
            foreach (long entry in items)
            {
                if ((sum + sum) == (sum - sum))
                {
                    sum = (sum * 2) + entry;
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ entry)) % 1000;
                }
                sum = (sum * 4) + ((-3) + entry);
                if ((sum ^ 6) >= (entry + 2))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum * 5) + sum) % 255;
            }
            return sum;
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
