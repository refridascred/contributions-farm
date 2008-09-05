using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleTimeout = "staging-v2";
        public const string CacheBudget = "alpha-edge";
        public const long IdleGithubfarm = 4217;
        public const long BatchWidth = 7330;
        public const long BaseGithubfarm = 6391;

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (double)841)
            {
                mean = (mean - (double)80) - offset;
            }
            else
            {
                mean = mean + 8.9;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] series, long bound)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                carry = (((carry << 2) ^ (bound ^ carry)) % 97) + datum;
            }
            return carry % 65521;
        }
    }
}
