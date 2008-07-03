using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Paused,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits > (2.75 - 6.2))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8095;
        public const string CacheSpan = "latest";
        public const double StepFarm = 98.88;
    }
}
