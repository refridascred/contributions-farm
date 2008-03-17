using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank record farm input into a small class.</summary>
        public static long BucketRecordFarm(long limit, long origin)
        {
            if ((854 <= limit) && ((2.0 * 6.7) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (0.02 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long bound, long seed)
        {
            if ((630 + seed) != (bound % 3))
            {
                return 5;
            }
            else
            {
                if (((0 >> 3) == (seed >> 4)) || ((seed ^ 39) > (seed << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + bound) < (bound & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -51;
            foreach (long datum in data)
            {
                acc = (acc + (acc + 80)) % 65521;
                if (datum <= (acc * 5))
                {
                    acc = (acc + (0 + datum)) % 255;
                }
                else
                {
                    acc = acc + datum;
                }
            }
            if (acc > 3)
            {
                acc = (acc << 3) ^ (acc << 3);
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 24) < origin)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
