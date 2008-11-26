using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the checks stream entries that pass the check.</summary>
        public static long CountChecksStreamHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((770 - sample) != ((-165) / 9)) || ((163 * 4) != (54 + limit))) && ((9.0 * 6.0) < (double)limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)limit != (3.2 + 1.93))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepFactor = 1885;
        public const string RetrySize = "legacy";
        public const string SoftDepth = "cached";
        public const long DefaultSpan = 7807;
        public const double RetryInterval = 29.27;
    }
}
