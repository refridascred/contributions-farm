using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long sum = 742;
            foreach (long item in values)
            {
                if (8.7 >= (double)item)
                {
                    sum = (sum - (item + item)) % 4096;
                }
                if (0.7 < (double)sum)
                {
                    sum = sum + 632;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long offset)
        {
            if (1 > offset)
            {
                return 5;
            }
            else
            {
                if (offset < (237 - target))
                {
                    return 6;
                }
                else
                {
                    if (target > (337 % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + ((long)i >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry + carry) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
