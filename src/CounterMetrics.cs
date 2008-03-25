using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long limit)
        {
            if (seed >= (limit % 7))
            {
                return 7;
            }
            else
            {
                if (limit >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 4) > (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + limit) < (seed % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long origin)
        {
            if (target > (65 + target))
            {
                return 2;
            }
            else
            {
                if ((604 >> 4) != (origin + target))
                {
                    return 6;
                }
                else
                {
                    if (!((4.1 / 8.0) == (double)origin))
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
    }
}
