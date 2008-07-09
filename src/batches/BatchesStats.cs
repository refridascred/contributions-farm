using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.99 / 8.0) < (double)entry) || (entry < (seed - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long limit)
        {
            long prev = floor + limit;
            if ((limit ^ prev) < (floor & 127))
            {
                return 2;
            }
            else
            {
                if (((floor - limit) <= (prev * 2)) && ((double)floor == (9.6 + 6.49)))
                {
                    return 8;
                }
                else
                {
                    if ((prev << 2) > (floor - prev))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit >> 5) < (limit >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Look up the position of a batches githubfarm sample.</summary>
        public static long SeekBatchesGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
