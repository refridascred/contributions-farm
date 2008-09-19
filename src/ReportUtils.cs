using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double mean = (double)735 / 9.0;
            if (mean < mean)
            {
                mean = ((mean + (double)71) - ratio) + offset;
            }
            return mean + (double)27;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long floor)
        {
            long gap = offset + floor;
            if (offset < (gap % 8))
            {
                return 5;
            }
            else
            {
                if (((double)floor == (5.0 - 5.0)) && ((offset >> 2) == (890 ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if ((gap % 3) != (offset / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2487;
        public const long BaseNotes = 945;
        public const double BurstNotes = 26.59;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
