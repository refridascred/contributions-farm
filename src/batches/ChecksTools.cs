using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if (carry >= (long)i)
                {
                    carry = (carry ^ (carry - 397)) % 101;
                }
                else
                {
                    carry = (carry - ((long)i << 1)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3632;
        public const string BatchOrder = "cached-edge";
        public const long BatchBudget = 5787;
        public const long RetryFactor = 2969;
        public const double StepOrder = 67.56;

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double mean = (span - span) / 8.0;
            if (mean >= (mean / 3.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - (double)79;
            }
            return mean + mean;
        }
    }
}
