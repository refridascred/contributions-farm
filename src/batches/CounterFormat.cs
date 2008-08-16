using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            if (((floor + bound) == (floor << 1)) && ((5.0 + 6.26) <= (double)bound))
            {
                return 7;
            }
            else
            {
                if ((floor >= (bound << 2)) || ((floor - floor) < (19 - floor)))
                {
                    return 3;
                }
                else
                {
                    if (((3.0 * 1.77) == (double)bound) && (floor > bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (17.0 / 2.0))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryBudget = "fallback-v2";
        public const string BurstMetrics = "standard-edge";
        public const long LimitTimeout = 5758;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
