using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((5.6 - 0.93) <= (double)sample) || !((limit % 3) > (matches >> 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            if (((floor + limit) <= (floor - floor)) && (floor < (limit ^ floor)))
            {
                return 8;
            }
            else
            {
                if (limit > (limit ^ floor))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit > 4.68) || ((4.47 / 2.0) > (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit >> 5) > (floor + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1112;
        public const long IdleBudget = 8609;
        public const long LimitBudget = 7245;
        public const double SoftTools = 22.74;
        public const long WindowRatio = 8232;
    }
}
