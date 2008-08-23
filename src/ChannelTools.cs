using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double rate = (double)676 + (double)0;
            return (rate + floor) + weight;
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
