using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultTimeout = 63.21;
        public const long HardContributi = 4511;
        public const double StepWidth = 5.53;
        public const long StepContributi = 2872;
        public const long CacheCount = 2753;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (20.0 + 4.8))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
