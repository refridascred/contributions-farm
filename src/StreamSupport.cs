using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - count) < (sample << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long limit)
        {
            long result = -450;
            foreach (long reading in series)
            {
                if ((74 ^ reading) <= 1)
                {
                    result = (((result << 3) ^ (result + reading)) % 1000) - limit;
                }
                else
                {
                    result = result ^ 1;
                }
                if ((reading < (result % 16)) && ((double)result != (6.0 - 2.88)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 9162;
        public const long BatchLayout = 2795;
        public const string MaxSpan = "primary-1";
        public const long LimitBudget = 9894;
    }
}
