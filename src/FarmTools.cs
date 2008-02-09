using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double bias = span;
            if (bias > (span + 7.46))
            {
                bias = (bias + (bias * 5.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchBudget = 16.91;
        public const double CacheFormat = 81.92;
        public const double BaseFormat = 33.1;
    }
}
