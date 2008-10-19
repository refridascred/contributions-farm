using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long limit)
        {
            if ((limit + floor) >= (limit % 60))
            {
                return 8;
            }
            else
            {
                if ((limit ^ floor) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((721 + limit) <= (limit + 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - limit) != (limit - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long bound)
        {
            long next = target ^ bound;
            if ((bound ^ target) <= (target + target))
            {
                return 7;
            }
            else
            {
                if (!(bound >= (next >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 3) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
