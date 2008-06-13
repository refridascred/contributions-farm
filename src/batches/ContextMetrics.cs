using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset < (532 >> 2))
            {
                return 1;
            }
            else
            {
                if ((step * 4) > (-290))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (5.0 - 11.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= (8.0 * 3.95))
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((cell + hits) <= cell) || ((double)cell > 3.44)) || (cell > (cell + cell)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (score + score) ^ reading;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long delta = bound + step;
            if ((4 & 7) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound - step) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 5) < delta)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
