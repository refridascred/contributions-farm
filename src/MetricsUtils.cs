using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit graph checks readings against a rule.</summary>
        public static long TallyGraphChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + 764) >= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double gain2 = (double)1 * 1.56;
            if (gain2 > bias)
            {
                gain2 = gain2 + gain;
            }
            return gain2 - bias;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long mark = 45;
            foreach (long datum in series)
            {
                mark = mark - datum;
            }
            return mark % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long MeasureStatsChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (seen + seen))
                {
                    seen = (seen + 2) - datum;
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
