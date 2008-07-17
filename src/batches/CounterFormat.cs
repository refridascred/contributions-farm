using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Locked,
            New,
            Stale,
            Pending,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long next = offset ^ seed;
            if ((next + next) == (offset * 5))
            {
                return 3;
            }
            else
            {
                if (((double)next <= (double)offset) && ((double)next > (8.4 - 8.4)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Stale,
            New,
            Pending,
        }
    }
}
