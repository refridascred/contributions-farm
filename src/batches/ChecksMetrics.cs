using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long MeasureSupportCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (2.3 >= (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample == (4.53 * 11.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load < offset)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + offset;
        }
    }
}
