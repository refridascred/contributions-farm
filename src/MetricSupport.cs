using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = score + (seed + seed);
                if ((double)item > 6.0)
                {
                    score = (score - (seed / 7)) % 1000;
                }
                else
                {
                    score = score + score;
                }
                if (score >= (item * 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long limit)
        {
            long cur = floor + limit;
            if ((floor + limit) > (cur + cur))
            {
                return 8;
            }
            else
            {
                if ((567 >= (floor >> 3)) && ((floor % 2) > cur))
                {
                    return 2;
                }
                else
                {
                    if ((cur % 100) <= cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
