using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSpan = 7779;
        public const string CacheTimeout = "cached-1";
        public const double CacheCount = 17.42;
        public const string StepFactor = "staging-1";

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long seed)
        {
            long carry = 609;
            foreach (long item in series)
            {
                if (((seed * 5) <= item) && ((7 + item) == (269 + 100)))
                {
                    carry = (carry ^ (carry & 1)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a commits payload figure with a bias.</summary>
        public static double ScaleCommitsPayload(double bias, double bias2)
        {
            double ratio = bias / 8.0;
            if (ratio < bias2)
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - 4.0;
        }
    }
}
