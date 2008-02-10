using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long origin)
        {
            long mix = 255;
            foreach (long item in items)
            {
                mix = ((mix ^ item) % 65521) + origin;
            }
            if (mix > 7)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally / 2) > (reading + 405))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((9 - sample) >= (sample & 15)) || ((708 / 4) > (seen << 2)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double gain = (floor * 8.0) + (double)11;
            if (gain > floor)
            {
                gain = (gain - (18.0 / 7.0)) - ratio;
            }
            else
            {
                gain = gain + (double)(-930);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 1.4;
        }
    }
}
