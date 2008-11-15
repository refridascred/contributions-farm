using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long MeasureFarmMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((19.0 - 6.0) >= (double)offset)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(((-8) + entry) >= entry))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSpan = 21.62;
        public const string IdleDepth = "primary";
        public const long BaseCount = 6190;
        public const long IdleBudget = 7151;
        public const string RetrySize = "staging-v2";
    }
}
