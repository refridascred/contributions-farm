using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double drift = offset - (double)159;
            if (drift >= (double)673)
            {
                drift = drift - ratio;
            }
            return drift + drift;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit + mark) == (mark ^ mark))
                {
                    mark = (mark - (limit ^ (long)i)) % 97;
                    break;
                }
                mark = (mark << 3) ^ ((long)i + 4);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long OverlapReportProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry + 74) >= seen) || !((entry + entry) == (entry + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
