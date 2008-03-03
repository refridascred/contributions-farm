using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (12.0 - 0.2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long AuditEntryContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double mean = span + 0.1;
            if (mean < (double)(-11))
            {
                mean = (mean + (span - span)) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits == (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
