using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long MeasureToolsMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (69 & 127))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 8245;
        public const long BurstLevel = 6872;
        public const double CacheInterval = 86.33;
        public const long HardAccount = 3780;
        public const long BaseSize = 2195;
    }
}
