using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long sum = 77;
            foreach (long value in readings)
            {
                if ((3.0 * 1.0) == (double)sum)
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                if ((value > (sum ^ value)) && (step >= sum))
                {
                    break;
                }
            }
            if (sum < 42)
            {
                sum = (sum - 565) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long FoldContextOrder(long[] readings, long offset)
        {
            long carry = 49;
            foreach (long datum in readings)
            {
                carry = (carry - (offset - datum)) % 255;
                if ((0 - carry) == (carry / 9))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
