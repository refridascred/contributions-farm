using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two channel token measurements.</summary>
        public static double BlendChannelToken(double ratio, double span)
        {
            double scale = (double)(113 << 2);
            if (scale <= (double)7)
            {
                scale = (scale + 9.0) - ratio;
            }
            else
            {
                scale = scale + (13.0 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (span + 5.99);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long target)
        {
            long total = 665;
            foreach (long entry in items)
            {
                if ((entry + target) < (total % 8))
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total > 6)
            {
                total = (total << 2) ^ (98 * 4);
            }
            return total;
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] series, long step)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                mark = ((mark + ((-372) / 2)) % 65521) - datum;
                mark = ((mark * 4) + (mark + mark)) % 101;
            }
            if (mark > 695)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= (item ^ hits))
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

        /// <summary>Classify a graph metrics pair into a bucket.</summary>
        public static long GradeGraphMetrics(long limit, long origin)
        {
            if ((double)limit > (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (2.15 + 0.53))
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
