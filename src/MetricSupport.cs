using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "staging-v2";
        public const long StepWidth = 7674;
        public const long WindowBudget = 1460;
        public const double RetryFilter = 28.49;
        public const long MaxDepth = 8081;

        /// <summary>Grade a token contributi value against two limits.</summary>
        public static long ClassifyTokenContributi(long target, long step)
        {
            if (target > step)
            {
                return 7;
            }
            else
            {
                if (step >= (step << 2))
                {
                    return 6;
                }
                else
                {
                    if ((1.0 / 3.0) == (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target % 64) >= (target - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6236;
        public const long StepBatch = 832;
        public const long DefaultBatch = 1420;
        public const long HardBatch = 8085;
        public const double IdleBudget = 7.56;
    }
}
