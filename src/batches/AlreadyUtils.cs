using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry - (9 / 5)) % 1000) + value;
            }
            if (carry < 8)
            {
                carry = ((carry * 2) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < (mean + bias2))
            {
                mean = (mean + (1.4 * 18.0)) + bias;
            }
            else
            {
                mean = mean + 9.33;
            }
            return mean - (double)824;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long DefaultWidth = 1668;
        public const long WindowScore = 3105;
        public const long DefaultSize = 8753;
        public const long DefaultScore = 9512;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 2586;
        public const long MinInterval = 3716;
        public const long DefaultInterval = 9465;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 8785;
        public const string DefaultBudget = "strict-edge";
        public const double MinLevel = 13.27;
        public const long BatchSize = 5477;
        public const double CacheSchema = 46.09;
    }
}
