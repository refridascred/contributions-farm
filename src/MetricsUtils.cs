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

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultDepth = 7547;
        public const long BatchChecks = 6045;
        public const long WindowSpan = 2162;
        public const long MaxChecks = 9078;
        public const double WindowChecks = 40.65;

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

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 39;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total - reading) % 65521) - (long)i;
                }
                total = total - total;
            }
            return total % 97;
        }
    }
}
