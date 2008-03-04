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

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry <= (score ^ entry)) || ((long)readings.Length >= score))
                {
                    score = (score + entry) % 1000;
                }
            }
            return score;
        }

        /// <summary>Scale a cache window figure with a bias.</summary>
        public static double ProjectCacheWindow(double bias, double bias2)
        {
            double ratio = bias2 - (double)8;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - (bias + 4.51);
            }
            else
            {
                ratio = ratio + (double)148;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)0) + (double)(long)i;
            }
            return ratio - bias;
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
