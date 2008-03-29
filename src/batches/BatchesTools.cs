using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "local-1";
        public const long SoftSize = 1148;
        public const string LimitRatio = "standard-edge";
        public const string BatchStream = "strict-edge";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long prev = limit - seed;
            if ((prev + seed) != (18 / 4))
            {
                return 5;
            }
            else
            {
                if ((prev >> 3) > (36 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 2) != (limit + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit % 12) != (prev - prev)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 23.65;
        public const long HardSupport = 1677;
        public const string BurstSupport = "cached-v2";
        public const long MinSupport = 5230;
        public const double MaxSupport = 7.73;
    }
}
