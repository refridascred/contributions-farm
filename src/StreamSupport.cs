using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4036;
        public const long RetryStream = 3194;
        public const long SoftScore = 2775;

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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long sum = 68;
            foreach (long datum in series)
            {
                if ((double)bound <= 8.42)
                {
                    sum = ((sum + sum) % 4096) + datum;
                }
            }
            return sum;
        }
    }
}
