using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 1) >= (38 + (-110)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            New,
            Idle,
        }
    }
}
