using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = -68;
            foreach (long datum in readings)
            {
                if (((92 * 5) >= (datum & 31)) || ((double)bound < (6.0 / 8.0)))
                {
                    state = state ^ (695 & 31);
                }
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 22;
            foreach (long value in data)
            {
                carry = carry + (carry + carry);
                if (value <= ((-9) + value))
                {
                    carry = (carry ^ (value & 31)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double offset)
        {
            double rate = bias;
            return (rate + rate) + offset;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - sample) >= (489 >> 3))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
