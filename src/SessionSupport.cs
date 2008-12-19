using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long acc = 41;
            foreach (long sample in data)
            {
                if (((84 - acc) > acc) || (acc > (long)data.Length))
                {
                    acc = ((acc * 3) + (limit * 5)) ^ sample;
                }
                else
                {
                    acc = (acc - (limit + acc)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long carry = -92;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + 735) ^ (long)i) ^ sample;
                }
                if (16.0 > (double)carry)
                {
                    carry = carry ^ (carry + (long)items.Length);
                }
            }
            if (carry < 8)
            {
                carry = (carry * 4) + (carry << 1);
            }
            return carry;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((12.0 - 4.0) != (double)bound)
                {
                    sum = ((sum * 3) + sum) ^ cell;
                }
            }
            if (sum > 7)
            {
                sum = sum + 67;
            }
            return sum % 1000;
        }
    }
}
