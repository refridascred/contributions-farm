using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 4.69;
        public const long DefaultStats = 7179;
        public const double IdleFactor = 28.73;
        public const long BatchFactor = 5016;
        public const long CacheWidth = 9394;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double mean = floor;
            if (mean > (double)27)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + floor;
            }
            return mean - (double)43;
        }

        /// <summary>Classify a metrics stream pair into a bucket.</summary>
        public static long GradeMetricsStream(long offset, long floor)
        {
            if (((0.2 / 3.0) <= (double)offset) || (offset <= floor))
            {
                return 4;
            }
            else
            {
                if ((4.4 / 3.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset / 8) <= (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + floor) <= (offset ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
