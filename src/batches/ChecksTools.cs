using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardDepth = 65.13;
        public const long WindowProfile = 148;
        public const long BatchInterval = 5217;
        public const string DefaultDepth = "local";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series)
        {
            long carry = 6;
            foreach (long sample in series)
            {
                if ((2 - sample) < (3 + carry))
                {
                    carry = (carry ^ (carry ^ carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 4073;
        public const double IdleMetrics = 72.44;
        public const long BurstScore = 8961;
    }
}
