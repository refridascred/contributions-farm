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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((1.0 - 12.0) <= (double)bound) || ((((long)data.Length % 60) < (reading + reading)) || (reading <= (bound - bound))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LocateQueueGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
