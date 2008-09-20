using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long origin)
        {
            long next = limit - origin;
            if (!((next - origin) <= (next / 4)))
            {
                return 8;
            }
            else
            {
                if (((next / 6) < (next >> 2)) && (limit >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((next / 8) >= (origin >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 7) >= (limit + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry batches series from a seed.</summary>
        public static long DeriveEntryBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ carry) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry << 3) ^ (long)i) % 97) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the counter order series from a seed.</summary>
        public static long StepCounterOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (origin > sum)
                {
                    sum = (sum - (origin << 3)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
