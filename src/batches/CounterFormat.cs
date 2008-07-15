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

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long origin)
        {
            long state = 448;
            foreach (long cell in values)
            {
                if ((origin & 1) < state)
                {
                    state = (state + (cell + origin)) % 255;
                }
            }
            if (state < 5)
            {
                state = ((state * 5) + (origin - state)) % 4096;
            }
            return state;
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
