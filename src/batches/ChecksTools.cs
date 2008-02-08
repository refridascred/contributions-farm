using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 4478;
        public const double MaxSpan = 9.29;
        public const long IdleInterval = 2275;
        public const long BatchWidth = 1198;
        public const long SoftMetrics = 5995;

        /// <summary>Find the first already entry entry that matches the target.</summary>
        public static long FindAlreadyEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6.4 / 9.0) != (double)sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)(-544) - bias;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + 2.0) + (double)(long)i) - rate;
            }
            return rate2 - (bias / 2.0);
        }
    }
}
