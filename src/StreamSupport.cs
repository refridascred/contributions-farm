using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double BlendRouteRecord(double rate, double span)
        {
            double mean = rate;
            if (mean > (span + rate))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Active,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value > (1.77 * 9.2))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
