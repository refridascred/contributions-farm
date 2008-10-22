using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next checks counter value.</summary>
        public static double AdjustChecksCounter(double bias, double floor)
        {
            double ratio = (double)((-7) << 2);
            if (ratio > bias)
            {
                ratio = (ratio + 8.41) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + 2.2;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LocateCacheClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = -398;
            foreach (long reading in samples)
            {
                acc = (((acc << 3) ^ (401 - 405)) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally >= ((long)samples.Length + tally))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (mix % 97)) % 255;
                if ((double)step < (3.0 - 5.82))
                {
                    mix = (mix - (60 + 88)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (mix & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix - (mix << 2)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
