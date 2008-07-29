using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            New,
            Locked,
            Pending,
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long MeasureCommandEntryGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) < 74)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Locked,
            Draft,
            Active,
        }
    }
}
