using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 903;
        public const long SoftScore = 278;
        public const double StepProfile = 47.03;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                sum = (sum - (target & 63)) - reading;
                if (((double)target < (6.27 / 3.0)) && (target >= (target - 3)))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double ScaleGithubfarmSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (double)98)
            {
                drift = drift + (drift + 8.9);
            }
            else
            {
                drift = drift - rate;
            }
            return drift - bias;
        }
    }
}
