using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowInterval = "strict-edge";
        public const long SoftRatio = 3183;
        public const double HardSpan = 72.31;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                long lane = (floor & 7) + floor;
                if ((carry + floor) <= (cell + lane))
                {
                    carry = carry ^ (cell + lane);
                    lane = (lane * 2) + (cell ^ floor);
                    break;
                }
                if ((carry >> 4) > (carry % 100))
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long origin)
        {
            long offset = floor + origin;
            if ((4.04 - 3.6) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((floor - origin) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 2) >= (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
