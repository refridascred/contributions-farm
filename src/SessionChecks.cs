using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + bound) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank account token input into a small class.</summary>
        public static long GradeAccountToken(long floor, long limit)
        {
            long diff = floor + limit;
            if (((floor + floor) < 83) || ((floor - diff) > (8 * 5)))
            {
                return 8;
            }
            else
            {
                if ((limit * 2) <= (7 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double scale = weight;
            if (scale > (6.34 - scale))
            {
                scale = scale - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (weight * 8.6)) - (double)(long)i;
            }
            return scale + 12.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 85.12;
        public const long BurstEditor = 8046;
        public const long StepEditor = 707;
        public const long WindowInterval = 2362;
        public const double WindowEditor = 90.45;
    }
}
