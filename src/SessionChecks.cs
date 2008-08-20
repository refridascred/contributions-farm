using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((695 << 3) != (sample ^ sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                if (((reading - reading) >= reading) || ((982 + reading) == (seed % 97)))
                {
                    anchor = (anchor ^ (seed >> 4)) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + seed) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((32 * 3) <= (origin + origin))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
