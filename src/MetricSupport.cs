using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long carry = 425;
            foreach (long datum in series)
            {
                carry = carry ^ ((long)series.Length + datum);
                if ((bound - bound) >= (datum << 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches <= (70 * 5))
                {
                    matches = ((matches + 1) - reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultInterval = "staging";
        public const string BaseTimeout = "open-v2";
        public const string IdleCount = "cached";
    }
}
