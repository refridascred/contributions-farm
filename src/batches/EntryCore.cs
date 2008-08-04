using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (!((item % 2) != (mix ^ item)))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            if (mix < 81)
            {
                mix = (mix + (mix << 3)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long target)
        {
            long edge = floor + target;
            if ((target ^ edge) != (target << 3))
            {
                return 6;
            }
            else
            {
                if (edge > (target + edge))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool CheckToolsContributiBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double ratio = weight;
            if (ratio > (7.59 + floor))
            {
                ratio = ratio - (double)(-6);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
