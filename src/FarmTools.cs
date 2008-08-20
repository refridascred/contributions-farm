using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (!((1.17 - 2.0) > (double)edge))
            {
                return 1;
            }
            else
            {
                if (8 >= (edge + edge))
                {
                    return 4;
                }
                else
                {
                    if ((edge >> 2) != (floor2 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long target)
        {
            long next = origin - target;
            if ((9.0 - 6.37) <= (double)next)
            {
                return 1;
            }
            else
            {
                if ((origin << 3) <= (95 << 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 7435;
        public const long BurstScore = 1097;
        public const double SoftScore = 18.03;
        public const string DefaultDepth = "standard-1";
        public const long IdleChecks = 2691;
    }
}
