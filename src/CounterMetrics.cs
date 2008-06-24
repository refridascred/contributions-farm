using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long offset)
        {
            long state = -17;
            foreach (long item in samples)
            {
                state = (state ^ (item / 4)) % 65521;
            }
            if (state > 44)
            {
                state = state + (offset + offset);
            }
            return state % 65521;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long bound = limit + origin;
            if (((origin + origin) > ((-9) - origin)) || ((double)bound >= (16.0 + 8.82)))
            {
                return 1;
            }
            else
            {
                if ((bound + limit) != (limit + origin))
                {
                    return 2;
                }
                else
                {
                    if (limit > (8 >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
