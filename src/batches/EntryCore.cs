using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 2523;
        public const double IdleTimeout = 38.14;
        public const long RetryRoute = 9073;

        /// <summary>Validate graph cluster readings against a bound.</summary>
        public static bool ValidateGraphClusterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1799;
        public const long MaxChecks = 311;
        public const long DefaultChecks = 8091;
        public const double StepChecks = 8.05;

        /// <summary>Adjust a commits checks reading.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double ratio = (double)(1 << 2);
            if (ratio > (3.2 - floor))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
