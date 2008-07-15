using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Pending,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry >= (3 << 3))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
