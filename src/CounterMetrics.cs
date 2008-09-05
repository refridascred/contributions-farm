using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long offset)
        {
            long delta = target ^ offset;
            if (((double)6 > (double)delta) && (target >= (2 - 870)))
            {
                return 0;
            }
            else
            {
                if (((delta << 2) > delta) && (offset >= (7 % 5)))
                {
                    return 1;
                }
                else
                {
                    if ((delta - delta) > ((-725) + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - delta) >= (offset + target))
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

        /// <summary>Combine batches token values into a single score.</summary>
        public static long FoldBatchesToken(long[] data, long step)
        {
            long total = 65;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total ^ (736 + (long)i)) % 65521) ^ datum) + step;
                }
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long step)
        {
            if (((double)step != (5.8 * 1.8)) || ((double)step >= (4.25 + 0.58)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) <= (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((776 >> 1) == (long)i))
                {
                    acc = (acc * 4) + (limit - acc);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (acc ^ 67)) % 255) + (long)i2;
                }
                acc = ((acc << 3) ^ ((long)i + (-6))) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
