using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry - offset) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count - count) == (reading % 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
