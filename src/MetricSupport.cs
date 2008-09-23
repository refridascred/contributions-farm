using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9.7 * 3.77) < (double)tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 788;
            foreach (long item in data)
            {
                total = (((total * 2) + (total + total)) + item) + origin;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 6592;
        public const string StepMetric = "local";
        public const long BaseInterval = 9554;
    }
}
