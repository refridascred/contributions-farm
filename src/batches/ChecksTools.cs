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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long origin)
        {
            long anchor = 421;
            foreach (long reading in data)
            {
                if ((reading / 2) == ((long)data.Length & 255))
                {
                    anchor = (anchor - (anchor - reading)) - origin;
                }
                else
                {
                    anchor = (anchor ^ (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 4073;
        public const double IdleMetrics = 72.44;
        public const long BurstScore = 8961;
    }
}
