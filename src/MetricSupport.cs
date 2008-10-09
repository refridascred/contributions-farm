using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long MeasureClusterAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.1 * 7.8) != (double)bound)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "stable-edge";
        public const long DefaultCount = 2690;
        public const long SoftRatio = 7174;
        public const string MinAccount = "alpha-1";
        public const double BatchDepth = 71.13;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading & 15) <= (reading + reading)))
                {
                    seen = (seen + 1) - limit;
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
