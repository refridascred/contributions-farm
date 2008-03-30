using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 3426;
        public const long DefaultReport = 6126;
        public const long BatchWidth = 9635;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            if ((target & 31) == (target ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit / 8) < 8)
                {
                    return 1;
                }
                else
                {
                    if (((double)target < (19.0 + 0.49)) && ((limit - target) == (target + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + limit) <= (target - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardLevel = "legacy";
        public const double StepSize = 73.05;
        public const long DefaultOrder = 5223;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2923;
        public const long MinChecks = 3818;
        public const long LimitSpan = 4047;
        public const long BatchSpan = 5312;
        public const long BaseChecks = 7097;
    }
}
