using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long floor)
        {
            if ((seed ^ floor) >= seed)
            {
                return 3;
            }
            else
            {
                if (!(seed > (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long limit, long limit2)
        {
            if ((limit2 - limit) < (limit2 * 3))
            {
                return 2;
            }
            else
            {
                if (((5.2 - 19.0) > (double)limit) && ((double)limit != (12.0 - 1.89)))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 & 3) < (limit2 << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (1 >= (limit << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count command entry pairs that satisfy a relation.</summary>
        public static long PairCommandEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
