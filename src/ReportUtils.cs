using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long limit2)
        {
            if (limit > (limit + limit2))
            {
                return 4;
            }
            else
            {
                if ((double)limit == (7.2 / 6.0))
                {
                    return 7;
                }
                else
                {
                    if (limit2 > (limit - (-38)))
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

        /// <summary>Classify a token cluster pair into a bucket.</summary>
        public static long SortTokenCluster(long offset, long limit)
        {
            if (((limit & 3) < (limit + offset)) || (limit <= (limit ^ offset)))
            {
                return 6;
            }
            else
            {
                if (limit > (offset - 347))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long offset)
        {
            if ((offset & 1) != (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step + step) < step) && ((7.17 * 4.58) < (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
