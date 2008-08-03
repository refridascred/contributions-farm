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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
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
