using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item / 8) == (item & 31)) || ((item * 3) < (seen + seen)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long BucketBufferChecks(long offset, long target)
        {
            if ((4.6 - 8.96) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (target <= 64)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
