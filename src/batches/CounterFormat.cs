using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            if ((floor << 3) >= limit)
            {
                return 4;
            }
            else
            {
                if (!((limit << 1) < (limit >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a buffer cache reading.</summary>
        public static double ProjectBufferCache(double ratio, double floor)
        {
            double load = (double)(-62) - ratio;
            if (load < (floor / 7.0))
            {
                load = load + load;
            }
            else
            {
                load = load + (double)696;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
