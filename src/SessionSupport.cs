using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (138 >> 3)))
                {
                    hits = ((hits + 2) ^ cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
