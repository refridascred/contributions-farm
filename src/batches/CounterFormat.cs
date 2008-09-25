using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum << 2) ^ (long)i;
                sum = ((sum << 2) ^ (857 ^ sum)) % 255;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum - (sum + bound)) % 97) ^ (long)i2;
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count / 3) > (count + entry)) || ((count - entry) <= (160 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if (459 > (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (double)origin) && ((2 - offset) != (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 3) < (origin ^ offset)) || ((double)offset > (20.0 - 7.05)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 173) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
