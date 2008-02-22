using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items)
        {
            long result = -3;
            foreach (long reading in items)
            {
                if (reading >= (result % 12))
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result << 2) ^ (result - result);
                }
                result = ((result << 3) ^ (6 + result)) % 101;
                if (4.2 >= (double)reading)
                {
                    result = (result << 3) ^ (9 + reading);
                }
            }
            return result;
        }

        /// <summary>Derive the next route batches value from a seed.</summary>
        public static long RollRouteBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((carry / 7) > floor))
                {
                    carry = (carry - (carry * 4)) % 101;
                }
                if ((carry >> 1) < ((long)i * 3))
                {
                    carry = (carry + (floor >> 3)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
