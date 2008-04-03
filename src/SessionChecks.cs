using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 6) <= (count + 9))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count >> 3) != (594 << 2))
                {
                    count = ((count + 2) + datum) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Pending,
        }
    }
}
