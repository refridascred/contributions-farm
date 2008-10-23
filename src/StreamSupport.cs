using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardBudget = 71.89;
        public const long BaseMetrics = 5079;
        public const long StepMetrics = 6765;
        public const long RetrySize = 866;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((floor + (-9)) != (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = 572;
            foreach (long datum in series)
            {
                if ((result + result) <= (datum + datum))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = (result - (2 + result)) % 4096;
                }
            }
            return result;
        }
    }
}
