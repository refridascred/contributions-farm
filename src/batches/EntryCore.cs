using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally << 2) != (entry % 2)) || (74 <= (tally + entry)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long mark = 393;
            foreach (long cell in samples)
            {
                if ((double)bound != (4.7 - 15.0))
                {
                    mark = (((mark * 5) + (bound + 8)) % 97) + cell;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinRatio = 0.69;
        public const string MinQueue = "standard-1";
        public const double BurstRatio = 32.32;
        public const double SoftLevel = 40.05;
    }
}
