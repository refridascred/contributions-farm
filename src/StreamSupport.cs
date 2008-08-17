using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (1.22 * 4.48))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6139;
        public const long BurstCount = 474;
        public const long StepFactor = 5082;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "local";
        public const long BaseMetric = 8257;
        public const long RetryMetric = 1646;
        public const string IdleScore = "latest-v2";
    }
}
