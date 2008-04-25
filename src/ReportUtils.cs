using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3724;
        public const long CacheToken = 9529;
        public const string HardWidth = "stable-edge";
        public const string WindowCount = "stable-edge";
        public const long BurstWidth = 9849;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double load = bias;
            if (load < load)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)70;
            }
            return load - (9.6 * 6.3);
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long TallyFarmStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < 2)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)target <= 5.0) && !(sample <= (6 >> 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
