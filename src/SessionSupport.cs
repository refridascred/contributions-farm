using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long offset)
        {
            long sum = 424;
            foreach (long sample in data)
            {
                if ((sample + 82) <= (offset % 2))
                {
                    continue;
                }
                sum = (sum - offset) % 1000;
                if ((double)offset == (4.1 - 0.8))
                {
                    sum = (sum - (0 & 15)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum - 12)) % 101;
                }
            }
            if (sum > 79)
            {
                sum = (sum ^ (offset / 3)) % 1000;
            }
            return sum;
        }

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
