using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((58 - hits) < entry) || ((hits << 1) <= (hits & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a route session reading.</summary>
        public static double ScaleRouteSession(double ratio, double span)
        {
            double rate = (span - span) - (ratio / 7.0);
            return rate + (14.0 * 2.1);
        }
    }
}
