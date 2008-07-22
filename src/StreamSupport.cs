using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally < (sample - 998)))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 2;
            foreach (long sample in samples)
            {
                if ((12.0 * 15.0) == (double)(long)samples.Length)
                {
                    acc = ((acc - (800 % 97)) % 1000) + sample;
                }
                else
                {
                    acc = (acc << 3) ^ 24;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryScore = "latest-1";
        public const long SoftFactor = 3507;
        public const double MaxStream = 3.07;
    }
}
