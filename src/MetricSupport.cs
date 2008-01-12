using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 723;
        public const double RetryScore = 90.01;
        public const string BatchTimeout = "primary-v2";
        public const long LimitStream = 874;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double mean = weight / 6.0;
            if (mean < span)
            {
                mean = mean - (double)545;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)2) + (double)(long)i;
            }
            return mean - (double)490;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                if ((double)cell >= (3.45 * 9.1))
                {
                    score = score + (score % 16);
                }
                score = score - (score ^ score);
                if (!((2 + cell) == (cell - (-810))))
                {
                    score = ((score * 5) + (score / 4)) % 1000;
                }
            }
            return score;
        }
    }
}
