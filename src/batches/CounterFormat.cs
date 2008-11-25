using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long floor)
        {
            long span = bound + floor;
            if ((7.78 * 1.25) > (double)bound)
            {
                return 3;
            }
            else
            {
                if (((span << 2) > (floor ^ bound)) && ((7.4 - 4.9) >= (double)span))
                {
                    return 8;
                }
                else
                {
                    if (!(floor < (span - bound)))
                    {
                        return 5;
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
