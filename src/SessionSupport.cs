using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long score = 452;
            foreach (long value in data)
            {
                score = (score * 2) + (value + target);
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
