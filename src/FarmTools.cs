using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.0 - 4.25) >= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Pending,
            Stale,
            Active,
        }
    }
}
