using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long limit)
        {
            long cur = offset + limit;
            if ((11.0 + 7.4) >= (double)cur)
            {
                return 0;
            }
            else
            {
                if (((offset >> 2) >= (limit - limit)) && ((6.11 * 5.3) >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (long)i;
                result = (result ^ (result ^ floor)) % 65521;
                result = ((result << 2) ^ 28) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values, long step)
        {
            long sum = 255;
            foreach (long sample in values)
            {
                if ((double)sum > (double)step)
                {
                    sum = (sum + (sample % 97)) % 4096;
                }
            }
            return sum;
        }
    }
}
