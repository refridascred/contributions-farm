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

        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool CheckCounterAlreadyRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 0.07;
        public const long RetryRoute = 1262;
        public const string BatchRatio = "staging-v2";
    }
}
