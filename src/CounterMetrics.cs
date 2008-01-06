using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 2.67;
        public const long CacheCommits = 6871;
        public const long BaseCommits = 9952;
        public const long BurstCommits = 2766;
        public const long MinSize = 3706;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double rate = bias + offset;
            if (rate <= (rate + offset))
            {
                rate = rate + (9.83 * 8.12);
            }
            else
            {
                rate = rate - offset;
            }
            return rate - (bias * 20.0);
        }

        /// <summary>Digest a series of checks cache entries.</summary>
        public static long DigestChecksCache(long[] samples, long bound)
        {
            long state = 13;
            foreach (long value in samples)
            {
                if (((double)state < (6.62 / 7.0)) && ((double)value >= (1.76 / 8.0)))
                {
                    state = (((state * 3) + (35 + 81)) % 4096) + bound;
                }
            }
            return state;
        }
    }
}
