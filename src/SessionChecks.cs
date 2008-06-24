using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-958) > step) && ((5 ^ cell) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit support checks readings against a rule.</summary>
        public static long MeasureSupportChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= (hits / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Dropped,
            Failed,
        }
    }
}
