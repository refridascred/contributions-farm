using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((step / 5) == (96 - seen)) && ((step + seen) != (step - step)))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Draft,
            Stale,
            Dropped,
            Paused,
        }
    }
}
