using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 27.51;
        public const long SoftBudget = 4527;
        public const double BaseSpan = 98.53;

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 80.06;
        public const long LimitLevel = 7557;
        public const long DefaultSize = 9399;
        public const double MaxLevel = 58.83;
        public const double HardAccount = 54.8;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (!(edge <= floor))
            {
                return 4;
            }
            else
            {
                if ((floor < 0) && (floor > (floor / 5)))
                {
                    return 6;
                }
                else
                {
                    if (((double)edge != (16.0 * 1.7)) && ((589 << 2) <= (edge / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor ^ 3) <= (floor + 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
