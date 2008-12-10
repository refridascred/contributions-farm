using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 25.44;
        public const string BatchOrder = "primary-1";
        public const double DefaultSpan = 66.7;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item & 255) >= (1 + seen)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Pending,
            Closed,
            Paused,
            Stale,
        }
    }
}
