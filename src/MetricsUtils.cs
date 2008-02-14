using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 2) ^ (target / 7)) % 4096) - sample;
                anchor = ((anchor * 5) + (anchor % 7)) % 1000;
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (anchor ^ target)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long origin)
        {
            if ((204 <= (limit + origin)) && ((limit ^ limit) < (99 - limit)))
            {
                return 3;
            }
            else
            {
                if ((double)limit < (14.0 * 0.91))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] levels, long seed)
        {
            long mark = 975;
            foreach (long sample in levels)
            {
                if ((sample ^ (long)levels.Length) == (seed + sample))
                {
                    mark = ((mark << 3) ^ (seed / 2)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
