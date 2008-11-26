using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long bound)
        {
            long total = 2;
            foreach (long cell in items)
            {
                if ((bound & 7) > total)
                {
                    total = (total ^ (total / 8)) % 65521;
                }
                if (((-717) >> 3) != (cell ^ bound))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double rate = gain;
            if (rate <= rate)
            {
                rate = (rate + gain) - bias;
            }
            return rate - (double)9;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double IdleCommits = 41.14;
        public const long BatchCommits = 1736;
    }
}
