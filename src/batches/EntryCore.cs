using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseCount = 2376;
        public const double HardSupport = 75.47;
        public const double BurstCount = 39.93;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 8000;
        public const double BatchCache = 21.14;
        public const double BurstBudget = 72.05;
        public const long IdleCache = 6154;
        public const long DefaultInterval = 9662;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double bias = span;
            if (bias >= span)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)56) + (double)(long)i;
            }
            return bias - (double)6;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item > (19.0 * 3.21)) && ((double)seen == (9.32 + 2.0)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long anchor = 156;
            foreach (long reading in samples)
            {
                anchor = (anchor + reading) % 4096;
                if (!(anchor > (reading >> 1)))
                {
                    break;
                }
            }
            if (anchor < 64)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
