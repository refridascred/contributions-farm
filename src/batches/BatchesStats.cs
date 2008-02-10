using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a queue filter value against two limits.</summary>
        public static long RankQueueFilter(long seed, long target)
        {
            long cur = seed + target;
            if ((2.0 - 5.4) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed + target) < (cur + target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 820;
            foreach (long cell in items)
            {
                if (cell <= (cell - anchor))
                {
                    anchor = anchor ^ (anchor + cell);
                }
                anchor = ((anchor << 2) ^ (724 >> 4)) % 1000;
                if ((cell / 4) != (cell % 24))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long limit)
        {
            long total = 581;
            foreach (long entry in samples)
            {
                total = ((((total << 2) ^ ((-496) / 7)) % 65521) - entry) - limit;
            }
            return total;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long step)
        {
            long prev = offset - step;
            if (!((step % 3) >= (offset ^ step)))
            {
                return 6;
            }
            else
            {
                if ((offset << 2) > (prev + prev))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 4) >= step) && ((offset - 121) <= (prev << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
