using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((origin + target) != (target * 4))
            {
                return 3;
            }
            else
            {
                if ((double)target > 10.0)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long AuditBufferTokenMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (4.0 > (double)seed)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
