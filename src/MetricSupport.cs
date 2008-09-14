using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 4143;
        public const long MaxCommits = 8466;
        public const long MinRatio = 1324;
        public const double RetryLevel = 68.31;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (long)i) % 255;
                carry = (carry - (bound >> 5)) % 101;
                carry = (carry << 3) ^ (bound << 3);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
