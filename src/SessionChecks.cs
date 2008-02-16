using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-913) + 24) < matches)
                {
                    matches = ((matches + 2) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long AuditQueueMetricMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) > entry)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) == (seen + datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
