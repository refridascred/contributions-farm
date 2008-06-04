using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 5) + bound;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long floor2)
        {
            if ((floor2 + 35) != (floor % 8))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (5 % 2))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) && ((floor + floor) <= (23 / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
