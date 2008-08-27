using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftTimeout = "open";
        public const double SoftBudget = 79.97;
        public const long IdleDepth = 2157;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8.0 + 1.6) >= (double)entry)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long mix = 27;
            foreach (long reading in values)
            {
                if ((mix % 5) >= (reading << 2))
                {
                    mix = ((mix * 3) + (mix - reading)) % 101;
                }
            }
            return mix;
        }
    }
}
