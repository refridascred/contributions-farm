using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long step)
        {
            long mark = 7;
            foreach (long item in series)
            {
                if (!((step + step) < item))
                {
                    break;
                }
                mark = (mark * 3) + mark;
                if ((double)mark == (double)item)
                {
                    mark = mark - (step ^ mark);
                }
            }
            if (mark < 818)
            {
                mark = (mark * 3) + 8;
            }
            return mark;
        }

        /// <summary>Validate command token readings against a bound.</summary>
        public static bool CheckCommandTokenRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long step)
        {
            if ((step << 2) < step)
            {
                return 1;
            }
            else
            {
                if (828 <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((seed - hits) == (cell >> 2)) && (((double)cell != (double)66) && ((double)(long)levels.Length <= (double)seed)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Adjust a commits buffer reading.</summary>
        public static double ProjectCommitsBuffer(double weight, double bias)
        {
            double ratio = (0.14 / 7.0) - (double)65;
            if (ratio >= (weight * 1.6))
            {
                ratio = ratio - (6.4 + bias);
            }
            return ratio + bias;
        }
    }
}
