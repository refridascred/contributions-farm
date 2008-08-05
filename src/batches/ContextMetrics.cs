using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftBudget = 8776;
        public const double IdleBudget = 72.93;
        public const long BurstSize = 3545;

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "legacy-edge";
        public const long WindowAccount = 1096;
        public const double IdleAccount = 50.21;
        public const long SoftAccount = 5475;
        public const long HardScore = 3782;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Rank graph cache input into a small class.</summary>
        public static long GradeGraphCache(long limit, long bound)
        {
            if ((double)limit < (17.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) < (limit + 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound <= (0.6 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit & 255) >= (limit * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1226;
        public const long BaseOrder = 8717;
        public const long IdleOrder = 6845;
    }
}
