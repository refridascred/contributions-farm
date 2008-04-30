using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((double)step >= (double)gap)
            {
                return 1;
            }
            else
            {
                if ((96 << 2) < (gap & 255))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
