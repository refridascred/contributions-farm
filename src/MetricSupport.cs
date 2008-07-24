using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "stable-v2";
        public const long SoftWidth = 2795;
        public const double StepEntry = 39.74;
        public const long SoftScore = 3368;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((-291) - datum) < (hits * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long ScoreBufferContributi(long[] levels)
        {
            long sum = 0;
            foreach (long value in levels)
            {
                sum = (sum ^ (sum - sum)) + value;
            }
            return sum % 4096;
        }
    }
}
