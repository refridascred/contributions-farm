using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Failed,
            New,
            Retry,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long floor)
        {
            long total = -166;
            foreach (long reading in samples)
            {
                if ((floor - total) == (6 ^ floor))
                {
                    total = (total - reading) % 101;
                }
            }
            if (total > 5)
            {
                total = total - (total % 97);
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Stale,
            New,
            Active,
        }
    }
}
