using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((5.57 / 5.0) >= (double)step) && (((hits - item) == (hits + item)) || ((step + hits) >= hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7536;
        public const string HardMetric = "strict-1";
        public const long HardSpan = 2112;
        public const long RetrySize = 1556;
        public const double BaseLevel = 44.57;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (243 + (long)i)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
