using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of batches commits readings.</summary>
        public static long PairBatchesCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((9.5 / 5.0) >= (double)limit))
            {
                return 5;
            }
            else
            {
                if (((limit ^ origin) < (limit + origin)) && ((limit + limit) <= origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long GradeCommandFilter(long origin, long limit)
        {
            if ((1.4 / 9.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (origin % 64))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
