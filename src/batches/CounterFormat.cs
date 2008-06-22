using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long seed)
        {
            long diff = floor - seed;
            if (!(9.39 <= (double)diff))
            {
                return 1;
            }
            else
            {
                if (((seed ^ floor) >= floor) || ((diff % 10) <= (floor >> 5)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor * 2) <= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every counter batches entry stays within the limit.</summary>
        public static bool GuardCounterBatchesRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
