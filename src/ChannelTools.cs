using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 98.33;
        public const double WindowFactor = 57.34;
        public const double StepGraph = 69.89;
        public const long MaxDepth = 584;
        public const double BatchSize = 94.03;

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long floor)
        {
            if (target <= (target * 2))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) > (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if ((826 / 9) < (179 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + floor) == (target ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
