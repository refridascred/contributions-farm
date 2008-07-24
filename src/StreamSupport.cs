using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3995;
        public const long MaxCount = 8613;
        public const double StepDepth = 2.1;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long offset)
        {
            long edge = target ^ offset;
            if ((target - offset) >= (target & 3))
            {
                return 0;
            }
            else
            {
                if (edge <= (target + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 2) > (edge ^ 30))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)edge > (3.0 / 2.0)) && ((771 >> 5) <= edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
