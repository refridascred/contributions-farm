using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9603;
        public const long BurstInterval = 8002;
        public const long BurstBatches = 8994;
        public const long DefaultBudget = 9913;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (bound ^ carry)) % 1000) ^ (long)i2;
                }
                carry = ((carry << 2) ^ (carry / 7)) % 1000;
                carry = (carry - ((long)i + carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long state = 13;
            foreach (long item in data)
            {
                state = (state * 3) + (item << 3);
                if ((item >> 2) < (state + item))
                {
                    state = (state ^ (851 % 5)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (state + 70)) % 97;
                }
            }
            return state;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if ((offset > 8) && ((5.71 * 6.0) != (double)seed))
            {
                return 0;
            }
            else
            {
                if (!((offset & 127) >= (4 / 8)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + seed) == (seed / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (offset << 1))
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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev + limit) < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (2.04 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 12) == (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
