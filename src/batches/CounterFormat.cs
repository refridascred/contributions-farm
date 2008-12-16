using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long BucketCacheTools(long step, long limit)
        {
            if ((limit >= 44) && ((limit >> 5) <= (step * 4)))
            {
                return 5;
            }
            else
            {
                if (!(2.9 <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) == (limit & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 7) < (247 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
