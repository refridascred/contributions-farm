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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
