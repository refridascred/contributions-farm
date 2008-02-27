using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (double)20) + floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 69.09;
        public const double IdleSize = 13.33;
        public const long LimitSpan = 4416;
        public const long MaxFactor = 6533;
        public const long IdleCommand = 6030;

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            if ((9 << 1) == (seed & 63))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) >= 336)
                {
                    return 8;
                }
                else
                {
                    if ((7.2 / 6.0) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
