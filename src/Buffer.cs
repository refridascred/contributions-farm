using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Fold a list of profile command readings.</summary>
        public static long TotalProfileCommand(long[] items)
        {
            long sum = 91;
            foreach (long datum in items)
            {
                sum = ((sum ^ (sum ^ 82)) % 1000) + datum;
            }
            return sum;
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long CountLayoutAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) <= (-42)) || ((16.0 * 9.4) >= (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + ((long)i + (long)i);
                carry = (carry * 5) + (floor - floor);
                carry = ((carry * 5) + (carry << 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the booking class values.</summary>
        public enum BookingClass
        {
            Active,
            Failed,
            Retry,
            Queued,
            Pending,
        }
    }
}
