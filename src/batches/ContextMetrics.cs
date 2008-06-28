using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((10 - entry) >= ((-99) >> 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits > 13.0)
                {
                    hits = ((hits + 1) ^ reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long IterateBufferSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + 31) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many report metric samples are out of range.</summary>
        public static long MeasureReportMetricMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry + 46) < (entry % 100)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
