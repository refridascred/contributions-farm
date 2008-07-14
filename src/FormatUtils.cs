using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            long offset = limit - seed;
            if ((offset % 8) >= (70 + offset))
            {
                return 8;
            }
            else
            {
                if ((offset - limit) != (limit - offset))
                {
                    return 5;
                }
                else
                {
                    if ((limit - seed) < (seed % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 5) < (seed << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if ((double)bound2 == (8.0 - 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound2 ^ bound2) > (bound2 / 9))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels, long seed)
        {
            long mark = -16;
            foreach (long item in levels)
            {
                mark = ((mark ^ (3 / 2)) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long limit, long offset)
        {
            long delta = limit + offset;
            if (((double)delta >= (2.01 * 1.43)) || ((6.15 - 0.1) >= (double)offset))
            {
                return 2;
            }
            else
            {
                if (8.34 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (!(delta <= (offset - delta)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Idle,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Done,
            New,
        }
    }
}
