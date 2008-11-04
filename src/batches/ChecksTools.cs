using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            long next = floor - limit;
            if ((7 << 2) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if (9.01 >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 2) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double mean = (double)(97 >> 4);
            if (mean <= 0.66)
            {
                mean = (mean - (16.0 / 6.0)) - bias;
            }
            return mean + (rate + rate);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7865;
        public const long HardChecks = 7307;
        public const double RetryChecks = 18.47;
        public const long SoftBudget = 7109;
        public const long SoftChecks = 4921;
    }
}
