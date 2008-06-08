using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long carry = 5;
            foreach (long item in data)
            {
                carry = (carry + (997 - carry)) % 101;
                if (floor <= (item >> 5))
                {
                    carry = carry + (item + carry);
                }
                else
                {
                    carry = (carry ^ (carry ^ carry)) % 65521;
                }
                if (!((carry - 781) < carry))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (floor % 2);
            }
            return carry % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i >= (floor >> 5)))
                {
                    score = score + (score - score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
