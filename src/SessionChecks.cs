using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long limit)
        {
            long prev = origin + limit;
            if ((1.7 > (double)prev) || ((double)origin >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((0.8 - 8.2) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultWidth = 2736;
        public const long DefaultSize = 8868;
        public const long LimitBuffer = 2967;
        public const long BurstSpan = 6324;
        public const long IdleBudget = 6343;

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long WeighBufferChecks(long[] series)
        {
            long mark = 702;
            foreach (long value in series)
            {
                mark = (mark << 2) ^ value;
                mark = (mark * 5) + 80;
            }
            if (mark < 48)
            {
                mark = mark - (mark >> 5);
            }
            return mark % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4134;
        public const long HardContributi = 7499;
        public const double BatchLevel = 70.44;
        public const long DefaultRatio = 6138;
    }
}
