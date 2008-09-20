using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double mean = (double)735 / 9.0;
            if (mean < mean)
            {
                mean = ((mean + (double)71) - ratio) + offset;
            }
            return mean + (double)27;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = sum - (sample << 3);
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxTimeout = 4.87;
        public const double WindowFactor = 7.55;
        public const double IdleAlready = 75.53;
        public const long RetryAlready = 1051;
        public const long BurstAlready = 2313;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long offset)
        {
            long total = 834;
            foreach (long item in series)
            {
                if ((3.2 * 8.0) < (double)offset)
                {
                    total = ((total ^ (total / 2)) % 4096) + item;
                }
            }
            return total % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftCount = 5441;
        public const long CacheEditor = 4702;
        public const long IdleBudget = 1796;
        public const long BatchSize = 2552;
    }
}
