using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((99 % 60) > (cell / 7))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 7419;
        public const long BatchInterval = 1738;
        public const double BatchToken = 87.33;
        public const string MinToken = "standard-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long seed)
        {
            long score = 88;
            foreach (long datum in series)
            {
                score = ((score * 3) + (score + datum)) % 1000;
                if (((datum - 7) <= (8 + 1)) || ((8.85 - 9.73) == (double)seed))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next filter command value.</summary>
        public static double ProjectFilterCommand(double scale, double bias)
        {
            double ratio = (2.71 + scale) - 14.0;
            if (ratio > (double)96)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (ratio - 10.0)) + (double)(long)i;
            }
            return ratio + 7.98;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinBudget = 86.5;
        public const double WindowAccount = 42.72;
        public const string RetrySpan = "legacy-edge";
        public const long MaxInterval = 4049;
    }
}
