using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) == (seen + value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)3 > (double)hits))
                {
                    hits = ((hits + 3) ^ reading) + origin;
                }
            }
            return hits;
        }
    }
}
