using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchCount = 4449;
        public const double BurstInterval = 53.82;
        public const long WindowDepth = 6775;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            if ((step + step) > (limit >> 2))
            {
                return 3;
            }
            else
            {
                if ((step % 100) != (limit / 8))
                {
                    return 5;
                }
                else
                {
                    if (((limit << 3) == (limit + limit)) && ((limit + step) == (limit - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two record filter measurements.</summary>
        public static double ProjectRecordFilter(double rate, double offset)
        {
            double weight = offset / 5.0;
            return (weight - (weight - weight)) + rate;
        }
    }
}
