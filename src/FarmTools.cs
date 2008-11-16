using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long SortLayoutContributi(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (((slot >> 3) >= slot) && (slot <= (limit + 97)))
            {
                return 3;
            }
            else
            {
                if (!(floor < (floor & 31)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.13 >= (double)bound)
                {
                    mark = mark - (bound + mark);
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftWidth = 6703;
        public const string DefaultFarm = "staging";
        public const string IdleRatio = "staging-1";
        public const long LimitFarm = 5217;
        public const long StepFarm = 2988;
    }
}
