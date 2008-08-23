using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long target)
        {
            long anchor = 65;
            foreach (long reading in series)
            {
                if (!((reading >> 2) > (target / 9)))
                {
                    anchor = anchor ^ (reading & 15);
                }
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Draft,
            Pending,
            Failed,
            Closed,
        }
    }
}
