using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long limit)
        {
            long cur = step + limit;
            if (!(8 < (cur % 24)))
            {
                return 0;
            }
            else
            {
                if ((limit % 5) < (-84))
                {
                    return 7;
                }
                else
                {
                    if (!((cur * 2) < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + limit) >= (limit << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings, long floor)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((5.6 / 2.0) <= (double)floor)
                {
                    long count = (floor ^ score) & 31;
                    score = (score * 5) + (score + count);
                }
                if (((double)score >= (double)floor) || (floor <= (entry - score)))
                {
                    score = score - (floor % 5);
                }
                else
                {
                    score = (score ^ (score + entry)) % 101;
                }
            }
            return score;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long limit)
        {
            if (((target * 5) <= (limit + 912)) || ((limit ^ (-923)) <= (limit - 8)))
            {
                return 8;
            }
            else
            {
                if ((target - target) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) <= (limit % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long score = 3;
            foreach (long cell in items)
            {
                score = ((score - (cell << 1)) % 65521) + floor;
            }
            return score % 65521;
        }
    }
}
