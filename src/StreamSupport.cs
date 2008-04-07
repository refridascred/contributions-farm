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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] values)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                if ((anchor + anchor) >= 787)
                {
                    anchor = (anchor - sample) % 4096;
                }
                if (((5.0 + 5.65) >= (double)sample) || ((sample >> 4) < 754))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
