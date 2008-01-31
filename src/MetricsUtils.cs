using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 9) >= (hits * 4))
                {
                    hits = ((hits + 2) ^ item) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)(-624) != (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 6436;
        public const long LimitBudget = 783;
        public const long BatchSpan = 8775;

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double drift = 8.1;
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift - (drift * 4.0)) - (double)(long)i) - rate) + bias;
            }
            return drift - (double)(-696);
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
