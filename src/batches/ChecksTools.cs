using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const double BaseEntry = 16.37;
        public const double BatchSize = 44.46;
        public const long BatchEntry = 7282;

        /// <summary>Project the next githubfarm cluster value.</summary>
        public static double SmoothGithubfarmCluster(double gain, double floor)
        {
            double drift = floor;
            if (drift <= (drift / 9.0))
            {
                drift = (drift + (double)793) + gain;
            }
            else
            {
                drift = drift - (floor * 2.7);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (9.0 * 1.46)) + (double)(long)i;
            }
            return drift - (floor * 3.31);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 4618;
        public const double StepStream = 14.53;
        public const long WindowSpan = 9201;
        public const long RetryStream = 7371;
        public const double SoftCount = 27.26;

        /// <summary>Compare every pair of order notes readings.</summary>
        public static long PairOrderNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
