using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a metrics layout pair into a bucket.</summary>
        public static long GradeMetricsLayout(long target, long limit)
        {
            if (((double)target != (2.0 / 2.0)) && ((target & 3) == (limit - limit)))
            {
                return 5;
            }
            else
            {
                if (((4.39 / 5.0) < (double)limit) && (limit < (target - target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (5.4 * 0.76))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit / 4) < 775))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 69.09;
        public const double IdleSize = 13.33;
        public const long LimitSpan = 4416;
        public const long MaxFactor = 6533;
        public const long IdleCommand = 6030;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
