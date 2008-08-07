using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool CheckStatsCacheRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-1) << 2) <= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long bound, long seed)
        {
            if ((bound / 8) > (bound << 3))
            {
                return 6;
            }
            else
            {
                if (!((418 ^ 0) > (seed / 7)))
                {
                    return 5;
                }
                else
                {
                    if (!((seed % 16) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a contributi session pair into a bucket.</summary>
        public static long BucketContributiSession(long target, long step)
        {
            long offset = target - step;
            if ((-9) > target)
            {
                return 7;
            }
            else
            {
                if (86 >= (step - target))
                {
                    return 0;
                }
                else
                {
                    if (((step & 7) >= 9) && (offset > (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 2) > (cell >> 4))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
