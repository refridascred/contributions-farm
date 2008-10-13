using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if (((sample + sum) == (sum >> 1)) || ((sample - sample) == (sum - 37)))
                {
                    sum = sum - ((-300) >> 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const double LimitDepth = 96.92;
        public const long BatchFactor = 1828;
        public const long MinLevel = 9476;
        public const string DefaultRatio = "latest-v2";

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long reading in samples)
            {
                sum = ((sum ^ (seed & 255)) % 101) - reading;
            }
            if (sum < 9)
            {
                sum = (sum + ((long)samples.Length >> 4)) % 255;
            }
            return sum % 97;
        }
    }
}
