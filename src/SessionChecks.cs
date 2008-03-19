using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a cluster buffer pair into a bucket.</summary>
        public static long BucketClusterBuffer(long seed, long bound)
        {
            long span = seed - bound;
            if (bound >= (span / 3))
            {
                return 0;
            }
            else
            {
                if (((bound & 3) <= (seed ^ bound)) && ((span - span) != (bound & 255)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item % 10) > item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (7.06 * 17.0))
                {
                    seen = ((seen + 1) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
