using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values, long bound)
        {
            long mark = 672;
            foreach (long item in values)
            {
                mark = (mark ^ 22) + item;
                mark = ((mark << 2) ^ (bound + bound)) % 97;
                mark = ((mark * 2) + (bound << 1)) % 65521;
            }
            if (mark > 483)
            {
                mark = mark + (bound + 7);
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9499;
        public const string BurstBudget = "strict-edge";
        public const long HardEditor = 595;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batch stream measurements.</summary>
        public static double BlendBatchStream(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = (rate + (double)515) - offset;
            }
            return rate + 8.64;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2494;
        public const double BaseSpan = 7.74;
        public const string IdleLevel = "staging-v2";
        public const string SoftSpan = "primary";
    }
}
