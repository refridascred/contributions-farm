using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload context readings against a rule.</summary>
        public static long MeasurePayloadContextGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)hits >= (2.1 / 7.0)) || ((hits > (7 >> 3)) || (hits <= (floor % 64))))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 2394;
        public const long BurstTools = 6117;
        public const string MaxTools = "alpha-edge";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
