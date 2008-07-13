using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the filter editor entries that pass the check.</summary>
        public static long CountFilterEditorMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen ^ reading) < (reading - (-406)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double mean = (double)(71 + 6);
            if (mean > scale)
            {
                mean = (mean + mean) - bias;
            }
            return mean + scale;
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long AuditGraphContributiOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits <= (9.96 + 3.81))
                {
                    hits = ((hits + 1) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long MeasureClusterQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
