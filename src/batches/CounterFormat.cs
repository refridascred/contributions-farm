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

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (((bound - bound) >= (floor & 63)) && ((9.43 / 6.0) > (double)lane))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) == (floor / 7))
                {
                    return 0;
                }
                else
                {
                    if ((5.5 + 5.82) != (double)lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound <= (floor ^ floor)) && ((bound / 8) < (2 % 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
